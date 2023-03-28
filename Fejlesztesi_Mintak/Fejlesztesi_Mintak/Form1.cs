using Fejlesztesi_Mintak.Entities;
using Fejlesztesi_Mintak.MnbServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Fejlesztesi_Mintak
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rate = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = Rate;


            GetXmlData(GetRate());

        }

        private void GetXmlData(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var date = item.GetAttribute("date");

                var rate = item.ChildNodes[0];

                Rate.Add(new RateData()
                {
                    Date = DateTime.Parse(date)
                }
                );
            }
        }
            

        private string GetRate()
        {
            var mnbService =
            new MNBArfolyamServiceSoapClient();

            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var respones = mnbService.GetExchangeRates(request);
            var result = respones.GetExchangeRatesResult;



        }
           
    }
}
