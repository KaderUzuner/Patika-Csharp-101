namespace Interface_Örnek
{
    public class Civic : IOtomobil
    {
        public Sabitler HangiMarkanınAracı()
        {
            return Sabitler.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }

}
