namespace CSharpPractice.OOP.Mostenire
{
    internal class Persoana
    {
        private string nume;
        private string prenume;
        private int varsta;
        private bool isAngajat;

        public Persoana(string nume, string prenume, int varsta, bool isAngajat)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.varsta = varsta;
            this.isAngajat = isAngajat;
        }
    }
}