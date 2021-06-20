namespace Interface_Örnek
{
    public class Focus : IOtomobil
    {
        public Sabitler HangiMarkanınAracı()
        {
            return Sabitler.Ford;
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
