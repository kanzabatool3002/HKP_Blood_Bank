using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmSplash : Form
    {
        private const int TargetWidth = 640; // Constant folding_code optimization_my work
        public frmSplash()
        {
            InitializeComponent();
        }


        int move = 0;

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            //Write the code to show Loading Animation
            timerSplash.Interval = 20;
            panelMovable.Width += 5;

            move += 5;

            //If the loading is complete then display login form and close this form

            if (move == TargetWidth) // Compile-time evaluation code optimization_my work
            {
                //Stop the Timer and Close this Form
                timerSplash.Stop();
                this.Hide();

                //Display the Login Form
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            //Load the Timer
            timerSplash.Start();
        }
    }
}
