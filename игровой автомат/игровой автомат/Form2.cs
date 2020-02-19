using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace игровой_автомат
{
    public partial class Form2 : Form
    {
        int cash = 100;
       
        public Form2(string name, double money)
        {
            InitializeComponent();
            label5.Text = name;
            label7.Text = Convert.ToString(money);

           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers;
            int[] numsbers = new int[4];
            var rand = new Random();
            int a = rand.Next(10);
            int b = rand.Next(10);
            int c = rand.Next(10);
          
            if (a == b && b==c && a==c)
            {
                int d;
                    label7.Text = "You win";
                d = Convert.ToInt32(label7.Text) + cash;

                
            }
            else
            {
                int k;
                label7.Text = "You lose";
                k = Convert.ToInt16(label7.Text) - cash;
            }
        }
    }
}
