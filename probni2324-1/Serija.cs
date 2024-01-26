namespace probni2324_1
{
    internal sealed class Serija : Content
    {
        public override string Tip => "Serija";
        private Dictionary<string, int> epizode;
        public Serija(string naziv, decimal cijena)
            : base(naziv, cijena)
        {
            epizode = new Dictionary<string, int>();
        }
        public override string ToString()
        {
            string poruka = base.ToString()
                + ", popis epizoda:\n";
            foreach (var kvp in epizode)
            {
                poruka += "\t" + kvp.Key + " (trajanje: "
                    + kvp.Value / 60 + " h i "
                    + kvp.Value % 60 + " min)\n";
            }
            return poruka;
        }
        public int this[string s]
        {
            get
            {
                return epizode[s];
            }
            set
            {
                if (!epizode.ContainsKey(s))
                    epizode[s] = value;
            }
        }
    }
}
