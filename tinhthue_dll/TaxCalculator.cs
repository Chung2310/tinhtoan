namespace tinhthue_dll
{

    public class TaxCalculator
    {

        public double tien1, tien2;
        public double thue = 0.1;
        public double sum {  get; private set; }
        public double tinhtoathue()
        {
            return ((tien1 + tien2) + (1 + thue));
        }

    }
}
