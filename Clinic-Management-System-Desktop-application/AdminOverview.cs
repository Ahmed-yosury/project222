using Clinic_Management_System_Desktop_application.Ahmed_yosury;
using Clinic_Management_System_Desktop_application.Karim_Essam;
using Clinic_Management_System_Desktop_application.Safa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application
{
    public partial class AdminOverview : Form
    {
        public AdminOverview()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DoctorOverview doctor=new DoctorOverview();
            doctor.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist receptionist=new Receptionist();
            receptionist.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Hide();
        }
    }
}
