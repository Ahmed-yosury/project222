using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic_Management_System_Desktop_application.Karim_Essam
{
    public partial class DoctorOverview : Form
    {
        public DoctorOverview()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbSecond.Text = DateTime.Now.ToString("ss");
            lbDate.Text = DateTime.Now.ToString("MMMM dd yyyy");

        }

        private void DoctorOverview_Load(object sender, EventArgs e)
        {
            timer.Start();
        }
    }
}
