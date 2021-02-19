using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cupcake
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            list = new List<string>();
        }

        List<String> list;
        private void button1_Click(object sender, EventArgs e)
        {

           //Implemented the Cupcake Name to check if it has a value then add it to the list
            if (cupcakeName.Text != String.Empty)
            {
                list.Add(cupcakeName.Text);
                MessageBox.Show("Cupcake Name:" + cupcakeName.Text);

            }
            else
            {
                MessageBox.Show("Invalid Entry, please enter the cupcake name!");
            }


            //Implemented the Cupcake Price to check if it has a value then add it to the list
            if (cupcakePrice.Text != String.Empty)
            {
                list.Add(cupcakePrice.Text);
                MessageBox.Show("Cupcake Price:" + cupcakePrice.Text);
            }
            else
            {
                MessageBox.Show("Invalid Entry, please enter the cupcake price!");
            }

            //Implemented the Cupcake Created Date to check if it has a value then add it to the list
            if (cupcakeDate.Text != String.Empty)
            {
                list.Add(cupcakeDate.Text);
                MessageBox.Show("Cupcake Created Date:" + cupcakeDate.Text);
            }
            else
            {
                MessageBox.Show("Invalid Entry, please enter the cupcake created date!");
            }

            if (cupcakeModified.Text != String.Empty)
            {
                list.Add(cupcakeModified.Text);
                MessageBox.Show("Cupcake Modified Date:" + cupcakeModified.Text);
            }
            else
            {
                MessageBox.Show("Invalid Entry, please enter the cupcake modified date!");
            }

        }
    }
}
