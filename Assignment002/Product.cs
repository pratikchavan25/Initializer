using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment002
{
    public class Product
    {
        private int code;
        private string p_name;
        private double p_price;
        private double pdiscount;
        private double Original_Price;
        private double discountprice;

        public int Code 
        {
            set { code = value;  }
            get { return code; }
        }

        public string Prod_name
        {
            set { p_name = value; }
            get { return p_name; }
        }

        public double Prod_price
        {
            set { p_price = value; }
            get { return p_price; }
        }

        public double Prod_discount
        {
            set { pdiscount = value; }
            get { return pdiscount; }
        }

        public void CalculateDiscount()
        {
            Console.WriteLine("eNTER discount Amount::");
            int per=Convert.ToInt32(Console.ReadLine());

            double proDiscount = (Prod_price * per) / 100;
            
            discountprice=Prod_price-proDiscount;
            //iginal_Price = Prod_price * 0.5/100;

            //discount = Original_Price - Prod_price;

            
        }

        public string ToString()
        {
            return $"Product Code is {code} \nProduct Name is {p_name} \nProduct Price is {p_price} \n Product Discount is {discountprice}";
        }


    }
}
