namespace Interface_Örnek
{
    public class Corolla : IOtomobil
    {
        public Sabitler HangiMarkanınAracı()
        {
            return Sabitler.Toyota;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }

}
