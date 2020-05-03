using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerbill
{
    class Customer
    {
        // private data
        private int number;
        private string name;
        private string type;
        private double charge;

        // constant
        const double RES_FLAT_RATE = 6.00;
        const double COMM_FLAT_RATE = 60.00;
        const double IND_FLAT_OFF_RATE = 40.00;
        const double IND_FLAT_RATE = 76.00;
        const double RES_CHA_RATE = 0.052;
        const double COMM_CHA_RATE = 0.045;
        const double IND_CHA_OFF_RATE = 0.028;
        const double IND_CHA_RATE = 0.065;
        
        // public properties

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                if (value >= 0) number = value;
            }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
        
            }
        }

        public double Charge
        {
            get { return charge; }
            set
            {
                if (value >= 0) charge = value;
                
            }
        }

        //Customer  constructor
        public Customer(int nu  , string na ,  string t, double c)
        {
            number = nu;
            name = na;
            type = t;
            charge = c;
        }


        // public operations (methods)


        // methode to calculate the Residental  bill
        public static double residental(double KWH, out double rate)
        {
           return rate = KWH * RES_CHA_RATE + RES_FLAT_RATE;
        }

        // methode to caculate the Commercial bill
        public static double Commercial(double KWH, out double rate)
        {
            if (KWH < 1000)
            {
               return  rate = COMM_FLAT_RATE;
            }
            else
            {
              return  rate = COMM_FLAT_RATE + ((KWH - 1000) * COMM_CHA_RATE);
            }
        }
        //methode to Calculate the Industerial Peak-hours bill
        public static double IndusterialPeak(double KWH, out double rate)
        {
            if (KWH < 1000)
            {
               return rate = IND_FLAT_RATE;
            }
            else
            {
             return   rate = IND_FLAT_RATE + ((KWH - 1000) * IND_CHA_RATE);
            }
        }

        // methode to Calcute the Indestrial Off-peak hours
        public static double IndusterialOffPeak(double KWHOffPeak, out double rateOff)
        {
            if (KWHOffPeak < 1000)
            {
               return rateOff = IND_FLAT_OFF_RATE;
            }
            else
            {
             return  rateOff = IND_FLAT_OFF_RATE + ((KWHOffPeak - 1000) * IND_CHA_OFF_RATE);
            }
        }


        // methode to calculate the charge amount
        public double chargeAmount()
        {
            return charge;
        }

        public override string ToString()
        {
            return number.ToString() + ": " + name + ", " + type + ", " + "$"+ charge.ToString();
        }
    } // end class Customer
}

