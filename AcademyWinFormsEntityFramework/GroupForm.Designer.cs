namespace AcademyWinFormsEntityFramework
{
    partial class GroupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNameGroup = new System.Windows.Forms.TextBox();
            this.textBoxIdDep = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Назва групи: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Факультету";
            // 
            // textBoxNameGroup
            // 
            this.textBoxNameGroup.Location = new System.Drawing.Point(176, 23);
            this.textBoxNameGroup.Name = "textBoxNameGroup";
            this.textBoxNameGroup.Size = new System.Drawing.Size(298, 26);
            this.textBoxNameGroup.TabIndex = 2;
            this.textBoxNameGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxNameGroup_KeyDown);
            // 
            // textBoxIdDep
            // 
            this.textBoxIdDep.Location = new System.Drawing.Point(176, 83);
            this.textBoxIdDep.Name = "textBoxIdDep";
            this.textBoxIdDep.Size = new System.Drawing.Size(298, 26);
            this.textBoxIdDep.TabIndex = 3;
            this.textBoxIdDep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIdDep_KeyDown);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 145);
            this.Controls.Add(this.textBoxIdDep);
            this.Controls.Add(this.textBoxNameGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNameGroup;
        private System.Windows.Forms.TextBox textBoxIdDep;
    }
}