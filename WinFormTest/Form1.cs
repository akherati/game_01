using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTest
{
    public partial class Form1 : Form
    {
        private Random _random;
        public Form1()
        {
            InitializeComponent();
            _random = new Random();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();

            int x = _random.Next(0, 50);
            int y = _random.Next(0, 50);

            tank1.Top += y;
            tank1.Left += x;

            if (x >= this.Width || y >= this.Height)
            {
                timer1.Stop();
            }

        }

        private void Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button currentButton = (System.Windows.Forms.Button)sender;

            switch (currentButton.Name)
            {
                case "up":
                    {
                        if (this.smile.Top - 10 >= 0)
                        {
                            this.smile.Top = this.smile.Top - 10;
                        }

                        break;
                    }
                case "down":
                    {
                        if (this.smile.Bottom + 50 <= this.Height)
                        {
                            this.smile.Top = this.smile.Top + 10;
                        }

                        break;
                    }
                case "right":
                    {
                        if (this.smile.Right < this.panel1.Width)
                        {
                            this.smile.Left = this.smile.Left + 10;
                        }

                        break;
                    }
                case "left":
                    {
                        if (this.smile.Left >= 0)
                        {
                            this.smile.Left = this.smile.Left - 10;
                        }

                        break;
                    }

            }
        }
    }
}
