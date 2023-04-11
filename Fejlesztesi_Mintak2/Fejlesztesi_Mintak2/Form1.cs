using Fejlesztesi_Mintak2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fejlesztesi_Mintak2
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        private ToyFactory _factoryy;

        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _balls.Add(ball);
            mainPanel.Controls.Add(ball);
            ball.Left = -ball.Width;
        }

        private void conveyerTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _balls)
            {
                ball.MoveBall();
                if (maxPosition < ball.Left)
                {
                    maxPosition = ball.Left;
                }
            }

            if(maxPosition > 100)
            {
                var oldestBall = _balls[0];
                _balls.Remove(oldestBall);
                mainPanel.Controls.Remove(oldestBall);
            }

        }
    }
}
