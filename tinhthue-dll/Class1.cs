using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhthue_dll
{
    public class TaxCalculator
    {

        public double tien1, tien2;
        public double thue = 0.1;
        public double sum { get; private set; }
        public void tinhtoathue()
        {
           sum = ((tien1 + tien2) * (1 + thue));
        }

    }
}
