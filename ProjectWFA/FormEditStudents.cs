using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class FormEditStudents : Form
    {
        private int id;
        private DBManipulator manipulator;
        public FormEditStudents()
        {
            InitializeComponent();
        }
        public void Init(int id,int specID, string Fname,string Mname,string Lname,string Address,string Phone, string Email )
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadSpecialties();
            this.comboBoxSpecialty.DataSource = dTable;
            this.comboBoxSpecialty.ValueMember = "id";
            this.comboBoxSpecialty.DisplayMember = "name";

            this.id = id;
            this.numericUpDownID.Value = id;
            this.comboBoxSpecialty.SelectedValue = specID;
            this.textBoxFName.Text = Fname;
            this.textBoxMName.Text = Mname;
            this.textBoxLName.Text = Lname;
            this.textBoxAddress.Text = Address;
            this.textBoxPhone.Text = Phone;
            this.textBoxEmail.Text = Email;

        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.UpdateStudent(this.id, (int)this.numericUpDownID.Value, Convert.ToInt32(this.comboBoxSpecialty.SelectedValue),
           this.textBoxFName.Text,this.textBoxMName.Text,this.textBoxLName.Text,
           this.textBoxAddress.Text,this.textBoxPhone.Text,this.textBoxEmail.Text);
        }

        
    }
}
