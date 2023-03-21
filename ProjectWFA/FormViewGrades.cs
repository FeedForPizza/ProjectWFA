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
    public partial class FormViewGrades : Form
    {
        public FormViewGrades()
        {
            InitializeComponent();
        }

        private void FormViewGrades_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadGrade();
            this.dataGridViewGrades.DataSource = dTable;
            this.dataGridViewGrades.Refresh();
        }

        private void dataGridViewSpecialties_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridViewGrades.SelectedRows.Count == 1)
            {
                int id =
              Convert.ToInt32(this.dataGridViewGrades.SelectedRows[0].Cells[0].Value);
                string subject =
               this.dataGridViewGrades.SelectedRows[0].Cells[1].Value.ToString();
                int grade =
              Convert.ToInt32(this.dataGridViewGrades.SelectedRows[0].Cells[2].Value);

                FormEditGrades formEditSpecialty = new FormEditGrades();
                formEditSpecialty.Init(id,subject,grade);
                formEditSpecialty.ShowDialog();
            }

        }

        
    }
}
