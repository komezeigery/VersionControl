using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


using System.Windows.Forms;

namespace ExcelCreation
{
    public partial class Form1 : Form
    {

        RealEstateEntities context = new RealEstateEntities();

        List<Flat> flats;


        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
            LoadData();
            CreateExcel();
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
