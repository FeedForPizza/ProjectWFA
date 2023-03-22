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
    public partial class FormEditGrades : Form
    {
        private int id;
        public FormEditGrades()
        {
            InitializeComponent();
        }
        public void Init(int id, string subject, int grade)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadStudents();
            this.comboBoxStudent.DataSource = dTable;
            this.comboBoxStudent.ValueMember = "fnumber";
            this.comboBoxStudent.DisplayMember = "name";
            
            DataTable daTable = configurator.LoadSubjects();
            this.comboBoxSubject.DataSource = daTable;
            this.comboBoxSubject.ValueMember = "id";
            this.comboBoxSubject.DisplayMember = "name";

            this.id = id;
            this.comboBoxStudent.SelectedValue = id;
            this.comboBoxSubject.SelectedValue = subject;
            this.numericUpDownGrade.Value = grade;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           Configurator configurator = new Configurator();
           configurator.UpdateGrade(Convert.ToInt32(this.comboBoxStudent.SelectedValue),
           Convert.ToInt32(this.comboBoxSubject.SelectedValue),
           (int)this.numericUpDownGrade.Value);

        }

        
    }
}
