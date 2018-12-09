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
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalsDataSet);

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalsDataSet.Doctors". При необходимости она может быть перемещена или удалена.
            this.doctorsTableAdapter.Fill(this.hospitalsDataSet.Doctors);

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
