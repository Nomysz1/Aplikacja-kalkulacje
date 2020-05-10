using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja
{
    class compoundInfo
    {
        string name, surname;
        string procedureCell;
        string detection; 
        DateTime date;
        public compoundInfo(string personalDetailsCell, string procedureCell, DateTime dt, string detection)
        {
            this.name = dividePersonalDetailsCell(personalDetailsCell)[1]; //this function returns a name
            this.surname = dividePersonalDetailsCell(personalDetailsCell)[0];
            this.date = dt;
            this.procedureCell = procedureCell;
            this.detection = detection;
        }

        private string[] dividePersonalDetailsCell(string personalDetailsCell)
        {
            return personalDetailsCell.Split(' ');
        }

        //ACCESSORS
        public string NAME
        {
            get
            {
                return this.name;
            }
        }

        public string SURNAME
        {
            get
            {
                return this.surname;
            }
        }

        public string PROCEDURECELL
        {
            get
            {
                return this.procedureCell;
            }
        }

        public string DATE
        {
            get
            {
                return this.date.ToString();
            }
        }

        public string DETECTION
        {
            get
            {
                return this.detection;
            }
        }

    }
}
