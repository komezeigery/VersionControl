using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VFFBMG_Gyak7.Entities
{
    public class Food : Product
    {
        public string Description { get; set; }

        public Food()
        {
            Click += Food_Click;
        }

        private void Food_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}\n{1}", Title, Description))
        }

        protected override void Display()
        {
            if (Calories < 750)
                BackColor = ColorDepth.LightGreen;
            else if (Calories < 1000)
                BackColor = ColorDepth.LightYellow;
            else
                BackColor = Color.Salmon;
                    
                 
        }
    }
}
