using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFFBMG_Gyak7
{
    List<Product> products = new List<Product> < Product > ();
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoScroll = true;
            GetProducts();
            DisplayProducts();
        }

        private void GetProducts()
        {
            var xml = new XmlDocument();
            var.Loadxml(GetXml("Menu.xml"));

            foreach(xmlELement item in xml.DocumentElement)
            {
                var name = item.SelectSingleNode("name").InnerText;
                var calories = item.SelectSingleNode("calories").InnerText;
                var description = item.SelectSingleNode("description").InnerText;
                var type = item.SelectSingleNode("type").InnerText;

                if(type == "food")
                {
                    var p = new Food()
                    {
                        Title = name,
                        Calories = int.Parse(calories),
                        Description = description

                    };
                    _products.Add(p);
                }
                else
                {
                    var p = new Drink()
                    {
                        Title = name,
                        Calories = int.Parse(calories)
                    };
                    _products.Add(p);
                }
            }
        }

        private string GetXml(string fileName)
        {
            using(var sr = new StreamReader(fileName, Encoding.Default))
            {
                var xml = sr.ReadToEnd;
                return xml;
            }
        }



    }
}
