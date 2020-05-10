using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xceed.Words.NET;


namespace Aplikacja
{
    public partial class Form1 : Form
    {
        xlsx _xlsx;

        public Form1()
        {
            InitializeComponent();

            _xlsx = new xlsx();

            this.BtnConfirm.Click += new EventHandler(btn_Click);
            this.SrcPath.MouseClick += new MouseEventHandler(showOpenFileDialog);
            this.SrcPattern.MouseClick += new MouseEventHandler(showOpenFileDialog);

            this.SrcPath.Text = Settings.read("SrcPath");
            this.SrcPattern.Text = Settings.read("SrcPattern");
            this.DealNoTb.Text = Settings.read("DealNoTb");

            Console.WriteLine("*** Funkcje programu zostały załadowane poprawnie ***");
        } 

        private void setUpAvaliabilityOfSpecificTextBoxes(bool choice)
        {
            this.TbName.Enabled = this.TbSurname.Enabled = this.maskedTBDate.Enabled = choice;
        }

        private void chBox_Click(object sender, EventArgs e)
        {
            CheckBox chBox = sender as CheckBox;
            bool isTrue = chBox.Checked;
            if (isTrue == true)
                setUpAvaliabilityOfSpecificTextBoxes(!isTrue);
            else
                setUpAvaliabilityOfSpecificTextBoxes(!isTrue);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string tmpName, tmpSurname, tmpscrPath, tmpSrcPattern, dealNo;
            tmpName = this.TbName.Text;
            tmpSurname = this.TbSurname.Text;
            tmpscrPath = this.SrcPath.Text;
            tmpSrcPattern = this.SrcPattern.Text;
            dealNo = this.DealNoTb.Text;

            if (tmpName.Replace(" ", "") != "" && tmpSurname.Replace(" ", "") != "" && tmpscrPath.Replace(" ", "") != "" && tmpSrcPattern.Replace(" ", "") != "" && dealNo.Replace(" ", "") != "")
                if (System.IO.File.Exists(this.SrcPattern.Text) && System.IO.File.Exists(this.SrcPath.Text))
                {
                    string name, surname, date;
                    name = this.TbName.Text;
                    surname = this.TbSurname.Text;
                    date = this.maskedTBDate.Text;
                    
                    try
                    {
                        _xlsx.readReport(SrcPath.Text);
                        _xlsx.readPrices(SrcPattern.Text);

                        _xlsx.showList();

                        date = date.Replace(" ", "");

                        List<compoundInfo> ptr_f = new List<compoundInfo>();
                            if (date.Length == 10)
                                ptr_f = _xlsx.findPatient(name, surname, date);
                            else
                                ptr_f = _xlsx.findPatient(name, surname, null);
                            if (ptr_f.Count > 1)
                            {
                                int i = 0;
                                foreach (compoundInfo item in ptr_f)
                                {
                                    StringBuilder builder = new StringBuilder();
                                    Console.WriteLine(i);
                                    builder.Append(name).Append(" ").Append(surname).Append("-" + (++i).ToString()).Append(".docx");
                                    DocX document = DocX.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + builder.ToString());

                                    bool condition = docHelper.addParagraph(document, "Nazwa i adres świadczeniodawcy:", null) &&
                                        docHelper.addParagraph(document, "Numer umowy:", string.Concat(" ", this.DealNoTb.Text)) &&
                                        docHelper.addParagraph(document, "1. Imię i nazwisko:", string.Concat(" ", name, " ", surname)) &&
                                        docHelper.addParagraph(document, "2. Data urodzenia:", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "3. Nr identyfikacyjny:", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "4. Dokument uprawniający do świadczeń:", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "Rozpoznanie: ", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "Kod ICD10: ", item.DETECTION) &&
                                        docHelper.addParagraph(document, "Data świadczenia", item.DATE.Split(' ')[0]);

                                string[] arrayOfProceduresTMP = item.PROCEDURECELL.Split(';');
                                List<string> arrayOfProcedures = new List<string>();
                                /*"89.04", "89.02", "89.71", "99.99902"*/
                                foreach (var it in arrayOfProceduresTMP)
                                    {
                                        if (it != "89.04" && it != "89.02" && it != "89.71" && it != "99.99902")
                                        {
                                            arrayOfProcedures.Add(it);
                                        }
                                    }

                                    var table = docHelper.addTbHeader(document, arrayOfProcedures.ToArray().Length);
                                    table = docHelper.addTBRows(document, table, arrayOfProcedures.ToArray(), _xlsx);

                                    document.InsertTable(table);
                                    docHelper.insertSum(document, _xlsx, item.PROCEDURECELL.Split(';'));
                                    docHelper.addSignPlace(document);

                                try
                                    {
                                        document.Save();
                                    }
                                    catch (Exception err)
                                    {
                                        MessageBox.Show(err.Message.ToString());
                                    }
                                }
                            }
                            else if (ptr_f.Count == 1)
                            {
                                int i = 0;
                            foreach (compoundInfo item in ptr_f)
                            {
                                StringBuilder builder = new StringBuilder();
                                Console.WriteLine(i);
                                builder.Append(name).Append(" ").Append(surname).Append("-" + (++i).ToString()).Append(".docx");

                                DocX document = DocX.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + builder.ToString());

                                bool condition = docHelper.addParagraph(document, "Nazwa i adres świadczeniodawcy:", null) &&
                                        docHelper.addParagraph(document, "Numer umowy:", string.Concat(" ", this.DealNoTb.Text)) &&
                                        docHelper.addParagraph(document, "1. Imię i nazwisko:", string.Concat(" ", name, " ", surname)) &&
                                        docHelper.addParagraph(document, "2. Data urodzenia:", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "3. Nr identyfikacyjny:", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "4. Dokument uprawniający do świadczeń:", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "Rozpoznanie: ", " /*WYPEŁNIĆ*/") &&
                                        docHelper.addParagraph(document, "Kod ICD10: ", item.DETECTION) &&
                                        docHelper.addParagraph(document, "Data świadczenia", item.DATE.Split(' ')[0]);
                                //docHelper.addParagraph(document, "Data świadczenia", string.Concat(item.DATE.Split('/')[0], '-', item.DATE.Split('/')[1], '-', item.DATE.Split('/')[2].Split(' ')[0]));

                                string[] arrayOfProceduresTMP = item.PROCEDURECELL.Split(';');
                                List<string> arrayOfProcedures = new List<string>();
                                /*"89.04", "89.02", "89.71", "99.99902"*/
                                foreach (var it in arrayOfProceduresTMP)
                                {
                                    if (it != "89.04" && it != "89.02" && it != "89.71" && it != "99.99902")
                                    {
                                        arrayOfProcedures.Add(it);
                                    }
                                }

                                //----------This section must be changed------------
                                var table = docHelper.addTbHeader(document, arrayOfProcedures.ToArray().Length);
                                    table = docHelper.addTBRows(document, table, arrayOfProcedures.ToArray(), _xlsx);
                                    //---------------------------------------------------
                                    document.InsertTable(table);
                                    docHelper.insertSum(document, _xlsx, item.PROCEDURECELL.Split(';'));
                                    docHelper.addSignPlace(document);

                                    try
                                    {
                                        document.Save();
                                    } catch(Exception err)
                                    {
                                        MessageBox.Show(err.Message.ToString());
                                    }
                                }
                            }
                            else
                                Console.WriteLine("Nie znaleziono osoby o podanych wartościach.");
                        

                       
                        bool isSettingSaved = Settings.save("SrcPath", this.SrcPath.Text) && Settings.save("SrcPattern", this.SrcPattern.Text) && Settings.save("DealNoTb", this.DealNoTb.Text) ? true : false;
                    }
                    catch (Exception err)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(err);
                        Console.ResetColor();
                    }
                }
                else
                    MessageBox.Show("Podane pliki nie istnieją", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Brak wypełnionych podstawowych wartości", "Ostrzeżenie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void showOpenFileDialog(object sender, MouseEventArgs e)
        {
            try
            {
                TextBox tb = sender as TextBox;
                Console.WriteLine("*** Wczytyanie pliku dla wejścia [{0}]", tb.Name);
                TextBox TBTemporary = sender as TextBox;
                repPath.InitialDirectory = "c:\\";
                repPath.Filter = "xlsx files (*.xlsx)|*.xlsx";
                repPath.ShowDialog();
                TBTemporary.Text = repPath.FileName;
                Console.WriteLine("*** Wczytano plik dla [{0}], o wartości {1}", tb.Name, repPath.FileName);
            } catch(Exception err)
            {
                Console.WriteLine("Błąd {0}", err);
            }
        }
    }
}
