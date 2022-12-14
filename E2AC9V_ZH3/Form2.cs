using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using E2AC9V_ZH3.Models;

namespace E2AC9V_ZH3
{
    public partial class Form2 : Form
    {
        Excel.Application xlApp; 
        Excel.Workbook xlWB;     
        Excel.Worksheet xlSheet; 
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                xlApp = new Excel.Application();


                xlWB = xlApp.Workbooks.Add(Missing.Value);


                xlSheet = xlWB.ActiveSheet;


                CreateTable();

                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                string errMsg = string.Format("Error: {0}\nLine: {1}", ex.Message, ex.Source);
                MessageBox.Show(errMsg, "Error");

                xlWB.Close(false, Type.Missing, Type.Missing);
                xlApp.Quit();
                xlWB = null;
                xlApp = null;
            }


             void CreateTable()
            {
                string[] fejlecek = new string[]
                {
                "Könyv azonosító",
                "Raktári szám",
                "Cím",
                "Ár"

                };
                Models.TextBookContext context = new Models.TextBookContext();
                var mindenkonyv = context.Textbooks.ToList();

                object[,] adatTömb = new object[mindenkonyv.Count(), fejlecek.Count()];
                for (int i = 0; i < fejlecek.Length; i++)
                {
                    xlSheet.Cells[1, i + 1] = fejlecek[i];
                }


                for (int i = 0; i < mindenkonyv.Count(); i++)
                {
                    adatTömb[i, 0] = mindenkonyv[i].TextbookId;
                    adatTömb[i, 1] = mindenkonyv[i].StockNumber;
                    adatTömb[i, 2] = mindenkonyv[i].Title;
                    adatTömb[i, 3] = mindenkonyv[i].Price;
                    
                }

                int sorokSzáma = adatTömb.GetLength(0);
                int oszlopokSzáma = adatTömb.GetLength(1);

                Excel.Range adatRange = xlSheet.get_Range("A2", Type.Missing).get_Resize(sorokSzáma, oszlopokSzáma);
                adatRange.Value2 = adatTömb;

                adatRange.Columns.AutoFit();

                Excel.Range fejllécRange = xlSheet.get_Range("A1", Type.Missing).get_Resize(1, 6);
                fejllécRange.Font.Color = Color.Black;
                fejllécRange.Font.Bold = true;
                fejllécRange.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                fejllécRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                fejllécRange.EntireColumn.AutoFit();
                fejllécRange.RowHeight = 25;
                fejllécRange.Interior.Color = Color.White;
                fejllécRange.BorderAround2(Excel.XlLineStyle.xlContinuous, Excel.XlBorderWeight.xlThick);


            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 elsoform = new Form1();


            this.Hide();


            elsoform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Biztos beakarod zárni az alkalmazást?", "Alkalmazás bezárása", MessageBoxButtons.YesNo);
            if (res == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();

            }
        }
    }
    }
