using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AcademyWinFormsEntityFramework
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }
        public int DepartmentId
        {
            get
            {
                return int.Parse(textBoxIdDep.Text);
            }
        }

        public string GroupName
        {
            get { return textBoxNameGroup.Text; }
        }
        private void textBoxNameGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBoxIdDep.Text))
                {
                    textBoxIdDep.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxIdDep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id;
                bool isNumeric = int.TryParse(textBoxIdDep.Text, out id);

                if (!isNumeric)
                {
                    MessageBox.Show("Повине бути числове значення");
                    textBoxIdDep.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(textBoxNameGroup.Text))
                {
                    textBoxNameGroup.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

    }
}
