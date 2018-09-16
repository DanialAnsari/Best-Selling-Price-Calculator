using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class MonteCarlo2
    {

       public double Treasury = 0;
       public int CustomerPday = 0;
       public int CustomerPday2 = 0;
       public int stockleft = 0;
       public int stockleft2 = 0;
       public double temp2 = 0;
           public  double PriceEstimation(double CostPrice, int MaxCustomers,int count,int totalstock,int Dec,double changeInprice ,double MaxSell )
        {
            
            Random R = new Random();
            double change =0;
            totalstock = totalstock*count;
            int stock = totalstock;
            double temp = CostPrice;
            
            int DecinCus2 = 0;
            double SellingPrice =CostPrice;
            int MinCustomers;
            int Customers;
            while (SellingPrice <= MaxSell)
            {
                int DecinCuS = Dec;
                change = change + (changeInprice/100);
                DecinCuS = DecinCuS + Convert.ToInt32(DecinCuS * change);
                DecinCus2 = Convert.ToInt32(DecinCuS * 0.85);
                DecinCus2 = R.Next(DecinCus2, DecinCuS);
                Treasury = 0;
                SellingPrice = CostPrice + (change * CostPrice);
                MaxCustomers = MaxCustomers - DecinCus2;
                MinCustomers = Convert.ToInt32(MaxCustomers * 0.2);
                
                for (int i = 0; i <7*count; i++)
                {
                    if (MaxCustomers > MinCustomers)
                    {
                        Customers = R.Next(MinCustomers, MaxCustomers);
                        CustomerPday = CustomerPday + Customers;
                        while (Customers > 0 && stock > 0)
                        {
                            stock--;
                            Treasury = Treasury + SellingPrice;
                            Customers--;
                        }

                    }
                }

                stockleft = stock;
                int left=totalstock-stock;
                stock=stock+left;
                Treasury = Treasury - (totalstock * CostPrice);

                Console.WriteLine("Treasury in first Week {0} at Price {1}", Treasury, SellingPrice);
                
                if (Treasury > temp2)
                {
                    temp2 = Treasury;
                    temp = SellingPrice;
                    CustomerPday2 = CustomerPday;
                    stockleft2 = stockleft;
                }
            }
            return temp;
        }

    }
}
