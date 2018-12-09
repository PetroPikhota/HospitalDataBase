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
    public partial class Communed : Form
    {
        public Communed()
        {
            InitializeComponent();
        }

        private void hospitalDoctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalDoctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalsDataSet);

        }

        private void Communed_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalsDataSet.HospitalDoctors". При необходимости она может быть перемещена или удалена.
            this.hospitalDoctorsTableAdapter.Fill(this.hospitalsDataSet.HospitalDoctors);

        }

        private void AddDoctorToHospitalButton_Click(object sender, EventArgs e)
        {
            AddDoc addDoc = new AddDoc();
            addDoc.Show();
        }
    }
}
