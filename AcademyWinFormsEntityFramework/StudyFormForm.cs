using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademyWinFormsEntityFramework
{
    public partial class StudyFormForm : Form
    {
        public StudyFormForm()
        {
            InitializeComponent();
        }
        public int StudentId
        {
            get
            {
                return int.Parse(textBoxIdStud.Text);
            }
        }

        public string FormName
        {
            get { return textBoxNameForm.Text; }
        }
        private void textBoxNameForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBoxIdStud.Text))
                {
                    textBoxIdStud.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxIdStud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id;
                bool isNumeric = int.TryParse(textBoxIdStud.Text, out id);

                if (!isNumeric)
                {
                    MessageBox.Show("Повине бути числове значення");
                    textBoxIdStud.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(textBoxNameForm.Text))
                {
                    textBoxNameForm.Focus();
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
