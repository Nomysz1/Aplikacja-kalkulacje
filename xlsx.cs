using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;


namespace Aplikacja
{
    class xlsx
    {
        string[] exceptions = {"89.04", "89.02", "89.71", "99.99902"};
        int rows;
        List<Details> lines;
        List<compoundInfo> patients;

        public xlsx()
        {
            rows = 0;
            lines = new List<Details>();
            patients = new List<compoundInfo>();
        }

        private void ConsoleOutputPrcINF(Details tmp, int index) //show infomration about a loaded file
        {
            Console.WriteLine("*** {0} - {1} - {2} - {3}", index, tmp.NAME, tmp.PROCEDURE, tmp.PRICE);
        }

        private void ConsoleOutputPatINF(compoundInfo tmp)
        {
            Console.WriteLine("*** Wczytano linie o pacjencie {0} {1} z datą wizyty {2} i procedurami {3}", tmp.NAME, tmp.SURNAME, tmp.DATE, tmp.PROCEDURECELL);
        }

        public void showList()
        {
            Console.WriteLine("*** LISTA WCZYTANYCH PACJENTÓW");
            foreach(compoundInfo item in patients)
            {
                Console.WriteLine("{0} {1} {2}", item.NAME, item.SURNAME, item.DATE);
            }
        }

        public List<compoundInfo> findPatient(string name, string surname, string date = null)
        {
            List<compoundInfo> patientsWCondition = new List<compoundInfo>();
            if (date != null)
            {
                DateTime convertedDate = Convert.ToDateTime(date);
                foreach (compoundInfo item in patients)
                {
                    if (name.ToLower() == item.NAME.ToLower() && surname.ToLower() == item.SURNAME.ToLower() && convertedDate.ToString() == item.DATE)
                    {
                        patientsWCondition.Add(item);
                    }
                }
            }
            else
            {
                foreach (compoundInfo item_ in patients)
                {
                    Console.WriteLine("Porównuje teraz {0} {1}", item_.NAME, item_.SURNAME);
                    if (name.ToLower() == item_.NAME.ToLower() && surname.ToLower() == item_.SURNAME.ToLower())
                    {
                        patientsWCondition.Add(item_);
                    }
                }
            }
            return patientsWCondition;
        }

        public double findCost(string proc)
        {
            foreach(Details item in lines)
            {
                if (item.PROCEDURE == proc)
                    return item.PRICE;
            }
            return 0.0;
        }

        public string findName(string proc)
        {
            foreach (Details item in lines)
            {
                if (item.PROCEDURE == proc)
                    return item.NAME;
            }
            return null;
        }

        private bool findDuplicatesPatients(compoundInfo temporary)
        {
            foreach(compoundInfo item in patients)
            {
                if (item.NAME == temporary.NAME && item.SURNAME == temporary.SURNAME && item.DATE == temporary.DATE && item.PROCEDURECELL == temporary.PROCEDURECELL)
                    return true;
                else
                    continue;
            }
            return false;
        }

        public void readPrices(string path)
        {
            FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(fs);
            do
            {
                while (excelReader.Read())
                {
                    foreach(string item in exceptions)
                    {
                        Details temporary = new Details(excelReader.GetString(0), excelReader.GetString(1), excelReader.GetDouble(2));
                        lines.Add(temporary);
                        rows++;
                        ConsoleOutputPrcINF(temporary, rows);
                    }
                }
            } while (excelReader.NextResult());
            fs.Close();
        }

        public void readReport(string path)
        {
            bool secondLine = false;
            FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(fs);
            do
            {
                while (excelReader.Read())
                {
                    if (secondLine == true)
                    {
                        if (excelReader.GetString(1) != null)
                        {
                            string prsDetails = excelReader.GetString(1);
                            DateTime date = excelReader.GetDateTime(7);
                            string detection = excelReader.GetString(10);
                            string icdLine = excelReader.GetString(11);
                            compoundInfo temporary = new compoundInfo(prsDetails, icdLine, date, detection);
                            if (findDuplicatesPatients(temporary) == false)
                            {
                                patients.Add(temporary);
                                ConsoleOutputPatINF(temporary);
                            }
                        }
                    }
                    secondLine = true;
                }
            } while (excelReader.NextResult());
            fs.Close();
        }

        public int ROWS
        {
            get
            {
                return this.rows;
            }
        }
    }
}
