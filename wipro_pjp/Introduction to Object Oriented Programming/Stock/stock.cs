using System;
using System.Collections.Generic;
using System.Text;

namespace STOCK
{
    class STOCK
    {
        private string name;
        private string symbol;
        private double pcprice;
        private double ccprice;
        
        public STOCK(string name,string symbol,double pcprice,double ccprice)
        {
            this.name = name;
            this.symbol = symbol;
            this.pcprice = pcprice;
            this.ccprice = ccprice;
        }

        public double getChangePercentage()
        {
            double pc = this.pcprice;
            double cc = this.ccprice;
            double change = Math.Abs(pc - cc)/pc*100;
            return change;

        }

        
    }
}
