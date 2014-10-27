using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultApp
{
    public partial class GPAUI : Form
    {
        public GPAUI()
        {
            InitializeComponent();
        }
        

        private void showButton_Click(object sender, EventArgs e)
        {
            GPA aGpa = new GPA(Convert.ToDouble(physicsTextBox.Text),Convert.ToDouble(chemistryTextBox.Text), Convert.ToDouble(mathTextBox.Text));

            
            averageTextBox.Text = aGpa.GetAverage().ToString();

            gradeLetterTextBox.Text = aGpa.GetGradeLetter();
        }
    }
}





























