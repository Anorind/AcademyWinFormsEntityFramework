namespace AcademyWinFormsEntityFramework
{
    partial class StudyFormForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxIdStud = new System.Windows.Forms.TextBox();
            this.textBoxNameForm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxIdStud
            // 
            this.textBoxIdStud.Location = new System.Drawing.Point(229, 109);
            this.textBoxIdStud.Name = "textBoxIdStud";
            this.textBoxIdStud.Size = new System.Drawing.Size(255, 26);
            this.textBoxIdStud.TabIndex = 7;
            this.textBoxIdStud.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIdStud_KeyDown);
            // 
            // textBoxNameForm
            // 
            this.textBoxNameForm.Location = new System.Drawing.Point(229, 50);
            this.textBoxNameForm.Name = "textBoxNameForm";
            this.textBoxNameForm.Size = new System.Drawing.Size(255, 26);
            this.textBoxNameForm.TabIndex = 6;
            this.textBoxNameForm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNameForm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id Студента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Назва форми навчання: ";
            // 
            // StudyFormForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 185);
            this.Controls.Add(this.textBoxIdStud);
            this.Controls.Add(this.textBoxNameForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudyFormForm";
            this.Text = "StudyFormForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIdStud;
        private System.Windows.Forms.TextBox textBoxNameForm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}