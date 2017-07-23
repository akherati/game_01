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

        public Form1()
        {
            InitializeComponent();

        }
        public Random rnd = new Random();

        public int x = new Random().Next(0, 20);
        public int y = new Random().Next(0, 20);
        private void Timer_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();


            //int x = rnd.Next(0, 500);
            //int y = rnd.Next(0, 500);

            //tank1.Location = new Point(0,100); 

            //tank1.Location = new Point((int)(new Random().Next(0, 1025)), (int)(new Random().Next(0, 545)));

            //tank1.Top += rnd.Next();
            //tank1.Left += rnd.Next();


            tank1.Top += y;
            tank1.Left += x;



            //       if (tank1.Left >= panel1.Width || tank1.Top >= panel1.Height)
            if (tank1.Location.X >= panel1.Width - tank1.Width)
            {
                //timer1.Stop();
                x = rnd.Next(-10, 0);
                y = rnd.Next(0, 10);

            }
            else if (tank1.Location.Y >= panel1.Height - tank1.Height)
            {

                x = rnd.Next(0,10);
                y = rnd.Next(-10,0);
            }

            else if (tank1.Location.Y <= 0)
            {
                x = rnd.Next(-10, 0);
                y = rnd.Next(0, 10);
            }

            else if (tank1.Location.X <= 0)
            {
                x = rnd.Next(0, 10);
                y = rnd.Next(0, 10);
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
