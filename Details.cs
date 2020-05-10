using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class Details
    {
        private string procedure;
        private string name;
        private double price;

        public Details(string procedure, string name, double price)
        {
            this.procedure = procedure;
            this.name = name;
            this.price = price;
        }

        public string PROCEDURE
        {
            get
            {
                return this.procedure;
            } set
            {
                this.procedure = value;
            }
        }

        public string NAME
        {
            get
            {
                return this.name;
            } set
            {
                this.name = value;
            }
        }

        public double PRICE
        {
            get
            {
                return this.price;
            } set
            {
                this.price = value;
            }
        }
    }
}
