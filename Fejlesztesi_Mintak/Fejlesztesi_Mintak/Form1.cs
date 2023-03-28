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

            PrintChart();
            dataGridView1.DataSource = Rate;


            GetXmlData(GetRate());

        }

        private void PrintChart()
        {
            chartRateData.DataSource = Rates;

            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Value";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }
        private void GetXmlData(string result)
        {
            var xml = new XmlDocument();
            xml.LoadXml(result);

            foreach (XmlElement item in xml.DocumentElement)
            {
                var date = item.GetAttribute("date");

                var rate =(XmlElement) item.ChildNodes[0];
                var currency = rate.GetAttribute("curr");
                var unit = int.Parse(rate.GetAttribute("unit"));
                var value = decimal.Parse(rate.InnerText);
                if(unit == 0)

                Rate.Add(new RateData()
                {
                    Date = DateTime.Parse(date),
                    Currency = currency,
                    Value = unit != 0
                        ? value / unit 
                        : 0
                        

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

            return result;

        }
           
    }
}
