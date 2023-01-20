namespace EntityLayer1
{
    public class EntityOgrenci
    {
        private string ad;
        public string Ad
        { 
            get { return ad; }
            set { ad = value; }
        }
        private string soyad;
        public string Soyad
        {
            get { return soyad; }
            set { soyad = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string numara;
        public string Numara
        {
            get { return numara; }
            set
            {
                numara = value;
            }
        }
        private string fotograf;
        public string Fotograf
        {
            get { return fotograf; }
            set
            {
                fotograf = value;
            }
        }
        private double bakiye;
        public double Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
    }
}