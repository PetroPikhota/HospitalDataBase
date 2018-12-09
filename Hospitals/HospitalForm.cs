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
    public partial class HospitalForm : Form
    {
        public HospitalForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.hospitalsDataSet);

        }

        private void HospitalForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalsDataSet.Hospitals". При необходимости она может быть перемещена или удалена.
            this.hospitalsTableAdapter.Fill(this.hospitalsDataSet.Hospitals);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hospitalsDataSet.Doctors". При необходимости она может быть перемещена или удалена.


        }

        private void hospitalsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hospitalsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hospitalsDataSet);

        }
    }
}
