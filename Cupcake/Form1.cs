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

            }
           
            //Implemented the Cupcake Price to check if it has a value then add it to the list
            if (cupcakePrice.Text != String.Empty)
            {
                list.Add(cupcakePrice.Text);
                
            }
            

            //Implemented the Cupcake Created Date to check if it has a value then add it to the list
            if (cupcakeDate.Text != String.Empty)
            {
                list.Add(cupcakeDate.Text);
            }

            //Implemented the Cupcake Modified Date to check if it has a value then add it to the list
            if (cupcakeModified.Text != String.Empty)
            {
                list.Add(cupcakeModified.Text);
            }
          
            if (cupcakeName.Text == String.Empty)
            {

                MessageBox.Show("Invalid Entry, please enter the cupcake name!");

            }
            else {
                MessageBox.Show("Cupcake Name: " + cupcakeName.Text + ", Cupcake Price: $" + cupcakePrice.Text + ", Cupcake Create Date: " + cupcakeDate.Text + ", Cupcake Modified Date: " + cupcakeModified.Text);
                
            }

            if(cupcakePrice.Text == String.Empty) {

                MessageBox.Show("Invalid Entry, please enter the cupcake price!");
            }
            else {
                MessageBox.Show("Cupcake Name: " + cupcakeName.Text + ", Cupcake Price: $" + cupcakePrice.Text + ", Cupcake Create Date: " + cupcakeDate.Text + ", Cupcake Modified Date: " + cupcakeModified.Text);
            }

            if(cupcakeDate.Text == String.Empty) {
               
             MessageBox.Show("Invalid Entry, please enter the cupcake created date!");
            }else {
                MessageBox.Show("Cupcake Name: " + cupcakeName.Text + ", Cupcake Price: $" + cupcakePrice.Text + ", Cupcake Create Date: " + cupcakeDate.Text + ", Cupcake Modified Date: " + cupcakeModified.Text);
            }

            if(cupcakeModified.Text == String.Empty) {
                MessageBox.Show("Invalid Entry, please enter the cupcake modified date!");
            }
            else {

                MessageBox.Show("Cupcake Name: " + cupcakeName.Text + ", Cupcake Price: $" + cupcakePrice.Text + ", Cupcake Create Date: " + cupcakeDate.Text + ", Cupcake Modified Date: " + cupcakeModified.Text);
            }

        }
    }
}
