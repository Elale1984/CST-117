using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * The purpose of this application is to show the utilization of check boxes, radio buttons, 
 * and list boxes. This is a very simple application that just displays a message based on the 
 * selections made with the controls. The user will choose a country, choose either to attack
 * or defend that country, and then choose who gets to know about it. The application will then
 * generate a messagebox with a message based on the user input.
 */
namespace PP2_ItemSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //upon this button click, the information recieved from the user will be processed and
        //a message will be shown in a messagebox based on the user input.
        private void btn_Execute_Click(object sender, EventArgs e)
        {
            
            if (lb_Country.SelectedIndex == -1)
            {
                MessageBox.Show("Plase Choose a Country");
            }
            else
            {
                String country = lb_Country.SelectedItem.ToString();
                String pr;

                //Checks weather which 
                if (rb_Attack.Checked)
                {

                    pr = checkPR();

                    MessageBox.Show("We are attacking " + country + "! " + pr);

                }
                else if (rb_defend.Checked)
                {
                    pr = checkPR();
                    MessageBox.Show("We are defending " + country + "! " + pr);

                }
                else
                {
                    MessageBox.Show("Please Select an action!!");
                }
            }
          
            

        }


        //method that sets the message for the appropriate selections and returns it as a 
        //string
        private String checkPR()
        {
            String pr;

            if (cb_Press.Checked && cb_Public.Checked)
            {
                pr = " \n\nThe meda and the people have been notified!!";
            }
            else if (cb_Public.Checked && !cb_Press.Checked)
            {
                pr = " \n\nThe media has been left out of the loop!";

            }
            else if(cb_Press.Checked && !cb_Public.Checked)
            {
                pr = " \n\nThe media has been notified. Propeganda is sure to follow!";
            }
            else
            {
                pr = " \n\nTop Secret. Classified!";
            }
            return pr;

        }
    }
}
