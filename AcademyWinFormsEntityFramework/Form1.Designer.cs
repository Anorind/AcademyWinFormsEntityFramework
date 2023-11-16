namespace AcademyWinFormsEntityFramework
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabPageDB = new System.Windows.Forms.TabControl();
            this.TabDepartments = new System.Windows.Forms.TabPage();
            this.TabGroups = new System.Windows.Forms.TabPage();
            this.TabForm = new System.Windows.Forms.TabPage();
            this.TabStudent = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.TabPageDB.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageDB
            // 
            this.TabPageDB.Controls.Add(this.TabDepartments);
            this.TabPageDB.Controls.Add(this.TabGroups);
            this.TabPageDB.Controls.Add(this.TabForm);
            this.TabPageDB.Controls.Add(this.TabStudent);
            this.TabPageDB.Location = new System.Drawing.Point(12, 12);
            this.TabPageDB.Name = "TabPageDB";
            this.TabPageDB.SelectedIndex = 0;
            this.TabPageDB.Size = new System.Drawing.Size(776, 426);
            this.TabPageDB.TabIndex = 0;
            this.TabPageDB.SelectedIndexChanged += new System.EventHandler(this.TabPageDB_SelectedIndexChanged);
            // 
            // TabDepartments
            // 
            this.TabDepartments.Location = new System.Drawing.Point(4, 29);
            this.TabDepartments.Name = "TabDepartments";
            this.TabDepartments.Padding = new System.Windows.Forms.Padding(3);
            this.TabDepartments.Size = new System.Drawing.Size(768, 393);
            this.TabDepartments.TabIndex = 0;
            this.TabDepartments.Text = "Departments";
            this.TabDepartments.UseVisualStyleBackColor = true;
            // 
            // TabGroups
            // 
            this.TabGroups.Location = new System.Drawing.Point(4, 29);
            this.TabGroups.Name = "TabGroups";
            this.TabGroups.Padding = new System.Windows.Forms.Padding(3);
            this.TabGroups.Size = new System.Drawing.Size(768, 393);
            this.TabGroups.TabIndex = 1;
            this.TabGroups.Text = "Groups";
            this.TabGroups.UseVisualStyleBackColor = true;
            // 
            // TabForm
            // 
            this.TabForm.Location = new System.Drawing.Point(4, 29);
            this.TabForm.Name = "TabForm";
            this.TabForm.Size = new System.Drawing.Size(768, 393);
            this.TabForm.TabIndex = 2;
            this.TabForm.Text = "Form";
            this.TabForm.UseVisualStyleBackColor = true;
            // 
            // TabStudent
            // 
            this.TabStudent.Location = new System.Drawing.Point(4, 29);
            this.TabStudent.Name = "TabStudent";
            this.TabStudent.Size = new System.Drawing.Size(768, 393);
            this.TabStudent.TabIndex = 3;
            this.TabStudent.Text = "Student";
            this.TabStudent.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(52, 461);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(173, 77);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Додати";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(269, 461);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(173, 77);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Видалити";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(498, 461);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(173, 77);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "Вихід";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 567);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.TabPageDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabPageDB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabPageDB;
        private System.Windows.Forms.TabPage TabDepartments;
        private System.Windows.Forms.TabPage TabGroups;
        private System.Windows.Forms.TabPage TabForm;
        private System.Windows.Forms.TabPage TabStudent;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonExit;
    }
}

