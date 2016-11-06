using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appetite
{
    public partial class Form1 : Form
    {
        int ob;
        public Form1()
        {
            InitializeComponent();
        }

        private void mainButton_Click(object sender, EventArgs e)
        {
            
        }
        private void gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            ob = gender.SelectedIndex;
        }

        private void mainButton_Click_1(object sender, EventArgs e)
        {
            int feet_here;
            int.TryParse(feet.Text, out feet_here);
            if ((age.Text != "") && (cWeight.Text != "") && (inch.Text != "") && ((feet_here > 5) || (feet_here == 5)))
            {
                double ibw_value = 0, Weight_lbs = 0, Calo_value1 = 0, Calo_value2 = 0;
                int age_here = int.Parse(age.Text);
                int weight_here = int.Parse(cWeight.Text);
                int inch_here = int.Parse(inch.Text);
                if (ob == 0)
                { //Check gender and find IBW
                    ibw_value = (50 + (2.3 * inch_here));
                    Weight_lbs = (ibw_value * 2.20462);
                    Calo_value1 = Weight_lbs * 13; //set Calories1	
                    Calo_value2 = Weight_lbs * 15; //set Calories2	
                }
                else
                {
                    ibw_value = ((45.5) + (2.3 * inch_here));
                    Weight_lbs = (ibw_value * 2.20462);
                    Calo_value1 = Weight_lbs * 10; //set Calories1
                    Calo_value2 = Weight_lbs * 14; //set Calories2
                }
                iWeight.Text = Convert.ToString(ibw_value);
                cIntake1.Text = Convert.ToString(Calo_value1);
                cIntake2.Text = Convert.ToString(Calo_value2);
                pIntake1.Text = Convert.ToString(ibw_value * 0.8); 
                pIntake2.Text = Convert.ToString(ibw_value * 1.8); 
                fIntake1.Text = Convert.ToString((Calo_value1 * 0.30) / 9);
                fIntake2.Text = Convert.ToString((Calo_value2 * 0.30) / 9);
            }
            else
            {
                MessageBox.Show("Check Inputs");
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
