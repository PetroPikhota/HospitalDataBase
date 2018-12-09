using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospitals
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HospitalAddButton_Click(object sender, EventArgs e)
        {
            HospitalForm hospitalForm = new HospitalForm();
            hospitalForm.Show();
        }

        private void DoctorAddButton_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm();
            doctorForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Communed communed = new Communed();
            communed.Show();
        }
    }
}
