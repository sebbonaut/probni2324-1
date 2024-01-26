namespace probni2324_1
{
    internal class Kolekcija<T> where T : Content
    {
        private List<T> popis;
        public Kolekcija(List<T> popis)
        {
            this.popis = popis;
            foreach (var item in popis)
                item.PromjenaCijene += Obavijest;
        }
        public void Informacije()
        {
            decimal ukupno = 0;
            Console.WriteLine("U kolekciji:");
            foreach (var i in popis)
            {
                Console.WriteLine("\t" + i.ToString()
                    + " (Tip: " + i.Tip + ")");
                ukupno += i.Cijena;
            }
            Console.WriteLine("Cijena: "
                + ukupno.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
                + " EUR.");
        }
        public void Obavijest(string naziv, decimal stara,
            decimal nova)
        {
            Console.Write("Promjena cijene: ");
            Console.WriteLine(naziv + " mijenja cijenu iz "
                + stara.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
                + " EUR u " + nova.ToString("0.00", System.Globalization.CultureInfo.InvariantCulture)
                + " EUR.");
            Informacije();
        }
    }
}
