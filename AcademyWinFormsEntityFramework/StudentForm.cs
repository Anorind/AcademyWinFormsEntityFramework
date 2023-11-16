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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        public int GroupId
        {
            get
            {
                return int.Parse(textBoxIdGroup.Text);
            }
        }

        public string StudentName
        {
            get { return textBoxNameStud.Text; }
        }
        private void textBoxNameStud_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(textBoxIdGroup.Text))
                {
                    textBoxIdGroup.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxIdGroup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int id;
                bool isNumeric = int.TryParse(textBoxIdGroup.Text, out id);

                if (!isNumeric)
                {
                    MessageBox.Show("Повине бути числове значення");
                    textBoxIdGroup.Focus();
                    return;
                }

                if (string.IsNullOrEmpty(textBoxNameStud.Text))
                {
                    textBoxNameStud.Focus();
                }
                else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void textBoxNameStud_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
