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
    public partial class FormViewSubjects : Form
    {
        public FormViewSubjects()
        {
            InitializeComponent();
        }

        private void FormViewSubjects_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadSubjects();
            this.dataGridViewSubjects.DataSource = dTable;
            this.dataGridViewSubjects.Refresh();
    
        }

        private void dataGridViewSpecialties_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridViewSubjects.SelectedRows.Count == 1)
            {
                int id =
               Convert.ToInt32(this.dataGridViewSubjects.SelectedRows[0].Cells[0].Value);
                string name =
               this.dataGridViewSubjects.SelectedRows[0].Cells[1].Value.ToString();
                FormEditSpecialty formEditSpecialty = new FormEditSpecialty();
                formEditSpecialty.Init(id, name);
                formEditSpecialty.ShowDialog();
            }

        }
    }
}
