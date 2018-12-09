using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Hospitals
{
    public partial class AddDoc : Form
    {
        SqlConnection connection;
        string connectionString;
        public AddDoc()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["Hospitals.Properties.Settings.HospitalsConnectionString"].ConnectionString;
        }

        private void AddDoc_Load(object sender, EventArgs e)
        {
            
        }
        private void opConnection()
        {
            if (!String.IsNullOrEmpty(DoctorBox.Text)&&!String.IsNullOrEmpty(HospitalBox.Text))
            {
                try
                {
                    connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter($"INSERT INTO [dbo].[HospitalDoctors] ([hospitalId],[doctorId],[dateStarted],[department],[position],[supervisor],[status],[partTime],[homeConsult],[lastModifiedBy]) select {int.Parse(HospitalBox.Text)},{int.Parse(DoctorBox.Text)},GETDATE(),department,country, supervisor,status, GETDATE(), homeConsult,'Petryk'from Doctors where Doctors.Id={int.Parse(DoctorBox.Text)}", connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                }
                catch (SqlException e)
                {
                    MessageBox.Show(e.Message.ToString());
                }
                connection.Close();
            }
            else MessageBox.Show("Text Boxes can't be Emty");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            opConnection();
        }
    }
}
