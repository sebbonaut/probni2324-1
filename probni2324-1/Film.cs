namespace probni2324_1
{
    internal sealed class Film : Content
    {
        public override string Tip => "Film";
        private int trajanje;
        public Film(string naziv, decimal cijena,
            int trajanje) : base(naziv, cijena)
                => this.trajanje = trajanje;
        public override string ToString()
            => base.ToString() + ", trajanje: "
                + trajanje / 60 + " h i "
                + trajanje % 60 + " min";
    }
}
