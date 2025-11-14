using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Picker
{
    public partial class Form1 : Form
    {
        //global variables
        Random randGen = new Random();
        int max = 50;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //create random values for each number
           int int1 = randGen.Next(1,max);
           int int2 = randGen.Next(1,max);
           int int3 = randGen.Next(1,max);
           int int4 = randGen.Next(1,max);
           int int5 = randGen.Next(1,max);
           int int6 = randGen.Next(1,max);
            //if int2 = int1 it picks a new number
            while(int2 == int1)
            { int2 = randGen.Next(1,max);}
            //if int 3 = int2 or int1 it picks a new number
            while(int3 == int2 | int3 == int1) 
            {int3 = randGen.Next(1,max);}
            //etc.
            while (int4 == int3 | int4 == int2 | int4 == int1)
            { int4 = randGen.Next(1,max);}
            while (int5 == int4 | int5 == int3 | int5 == int2 | int5 == int1)
            { int5 = randGen.Next(1,max);}
            while (int6 == int5 | int6 == int4 | int6 == int3 | int6 == int2 | int6 == int1)
            { int6 = randGen.Next(1,max);}

            //display numbers
            outputLabel.Text = int1.ToString() + " " + int2.ToString() + " " + int3.ToString() + " " + int4.ToString() + " " + int5.ToString() + " " + int6.ToString();
        }
    }
}
