using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace Aplikacja
{
    class docHelper
    {
        private const double spacingAfterVal = 20;
        static public Table addTbHeader(DocX document, int rows)
        {
            try
            {
                rows++;
                var table = document.AddTable(rows, 4);
                table.Design = TableDesign.TableNormal;
                table.Alignment = Alignment.center;
                table.Rows[0].Cells[0].Paragraphs[0].Append("Rodzaj kosztów");
                table.Rows[0].Cells[1].Paragraphs[0].Append("Koszt");
                table.Rows[0].Cells[2].Paragraphs[0].Append("ICD9");
                table.Rows[0].Cells[3].Paragraphs[0].Append("Uwagi");
                table.Design = TableDesign.TableGrid;
                return table;
            } catch(Exception e)
            {
                return null;
            }
        }

        static public Table addTBRows(DocX document, Table table, string[] arrOfICD, xlsx x_)
        {
            for(int i = 0; i < arrOfICD.Length; i++)
            {
                table.Rows[i + 1].Cells[0].Paragraphs[0].Append(x_.findName(arrOfICD[i])==null?"BRAK DANYCH": x_.findName(arrOfICD[i]));
                table.Rows[i + 1].Cells[1].Paragraphs[0].Append(x_.findCost(arrOfICD[i])==0.0?"BRAK DANYCH": x_.findCost(arrOfICD[i]).ToString());
                table.Rows[i + 1].Cells[2].Paragraphs[0].Append(arrOfICD[i]);
            }

            return table;
        }

        static public void insertSum(DocX document, xlsx x_, string[] arrOfICD)
        {
            double sum = 0.0;
            for(int i = 0; i < arrOfICD.Length; i++)
            {
                double tmpVal = x_.findCost(arrOfICD[i]) == 0.0 ? 0 : x_.findCost(arrOfICD[i]);
                sum += tmpVal;
            }
            Console.WriteLine(sum);
            addParagraph(document, "Suma kosztów świadczeń: ", string.Concat(sum.ToString(), " zł"));
        }

        static public bool addParagraph(DocX document, string key, string val)
        {
            try
            {
                var namePrh = document.InsertParagraph();
                namePrh.Append(key + " " + val)
                    .Bold()
                    .FontSize(12)
                    .SpacingLine(spacingAfterVal);

            } catch (Exception e)
            {
                return false;
            }
            return true;
        }

        static public bool addSignPlace(DocX document)
        {
            try
            {
                var dots = document.InsertParagraph();
                dots.Append("..................................")
                    .Alignment = Alignment.right;
                dots.FontSize(12)
                    .SpacingLine(spacingAfterVal + 20);
                var namePrh = document.InsertParagraph();
                namePrh.Alignment = Alignment.right;
                namePrh.Append("podpis")
                    .Bold()
                    .FontSize(12)
                    .SpacingLine(spacingAfterVal);
            } catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
