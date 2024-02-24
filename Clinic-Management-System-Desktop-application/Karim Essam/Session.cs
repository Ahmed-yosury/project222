using Clinic_Management_System_Desktop_application.Karim_Essam;
using database_test;
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
    public partial class Session : Form
    {
        ClinicDB clinicDB = new ClinicDB();
        public Session()
        {
            InitializeComponent();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            var pathiontdata = clinicDB.Patients.Where(a => a.done == false).Select(p => p).ToList();
            foreach (var item in pathiontdata)
            {
                NameValue.Items.Add(item.PatientName);
            }


        }

        private void NameValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Na = NameValue.SelectedItem.ToString();
            var datapatient = clinicDB.Patients.Where(o => o.PatientName == Na).FirstOrDefault();
            phonedata.Text = datapatient.PatientPhone;
            addressdata.Text = datapatient.PatientAddress;
            genderdata.Text = datapatient.PatientGender;
            agedata.Text = datapatient.PatientAge.ToString();
            maritaldata.Text = datapatient.PatientMaritalStatus;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pationtName = NameValue.SelectedItem.ToString();
            var data = clinicDB.Patients.Where(o => o.PatientName == pationtName).FirstOrDefault();

            if (data != null)
            {
                data.done = true;
                clinicDB.SaveChanges();
            }
            DoctorOverview doctor = new DoctorOverview();
            doctor.Show();
            this.Hide();
        }
    }
}

