namespace probni2324_1
{
    internal abstract class Content : IComparable<Content>
    {
        public event Action<string, decimal, decimal>? PromjenaCijene;
        private string naziv;
        private decimal cijena;
        public decimal Cijena
        {
            get => cijena;
            set
            {
                if(value <= 0)
                    throw new ArgumentOutOfRangeException();
                decimal staraCijena = cijena;
                cijena = value;
                if (staraCijena != cijena)
                {
                    PromjenaCijene?.Invoke(naziv, staraCijena, cijena);
                }
            }
        }
        public abstract string Tip { get; }
        public Content(string naziv, decimal cijena)
        {
            this.naziv = naziv;
            Cijena = cijena;
        }
        public override string ToString()
            => "Naziv: " + naziv + ", cijena: "
               + cijena.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture) + " EUR";

        public int CompareTo(Content? other)
            => other is null ? 0 : cijena.CompareTo(other.cijena);
    }
}
