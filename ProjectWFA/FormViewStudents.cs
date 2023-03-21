using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class FormViewStudents : Form
    {
        public FormViewStudents()
        {
            InitializeComponent();
        }

        private void FormViewStudents_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadStudents();
            this.dataGridViewStudents.DataSource = dTable;
            this.dataGridViewStudents.Refresh();
        }

        private void dataGridViewSpecialties_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridViewStudents.SelectedRows.Count == 1)
            {
                int id =
               Convert.ToInt32(this.dataGridViewStudents.SelectedRows[0].Cells[0].Value);
                int specID =
               Convert.ToInt32(this.dataGridViewStudents.SelectedRows[0].Cells[1].Value);
                string Fname =
               this.dataGridViewStudents.SelectedRows[0].Cells[2].Value.ToString();
                string Mname =
               this.dataGridViewStudents.SelectedRows[0].Cells[3].Value.ToString();
                string Lname =
               this.dataGridViewStudents.SelectedRows[0].Cells[4].Value.ToString();
                string Address =
               this.dataGridViewStudents.SelectedRows[0].Cells[5].Value.ToString();
                string Phone =
               this.dataGridViewStudents.SelectedRows[0].Cells[6].Value.ToString();
                string Email =
               this.dataGridViewStudents.SelectedRows[0].Cells[7].Value.ToString();

                FormEditStudents formEditStudents = new FormEditStudents();
                formEditStudents.Init(id,specID,Fname,Mname,Lname,Address,Phone,Email);
                formEditStudents.ShowDialog();
            }

        }
    }
}
