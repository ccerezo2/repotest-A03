using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSReview
{
    public class Estimate
    {
        public double TotalPrice { get; private set; }
        public double LinearLength { get; set; }
        public FencePanel Panel { get; set; }
        public List<FenceGate> GateList { get; set; }

        public double CalculatePrice()
        {
            //assuming the panel and Gates Exist and all are correct
            //there is no validation in this example
            double numberofpanels = Panel.EstimatedNumberOfPanels(LinearLength);
            //typecastinf ((int)numbervalue))
            if ((int)(numberofpanels *10.0)>((int)numberofpanels *10))
            {
                numberofpanels = (int)numberofpanels + 1;
            }
            if(Panel.Price== null)
            {
                throw new Exception("Panel Price is needed to create estimate");
            }
            else
            {
                TotalPrice += numberofpanels * (double)Panel.Price;
                foreach(var item in GateList)
                {
                    TotalPrice += item.Price;
                }
            }
            return TotalPrice;
        }
    }

}
