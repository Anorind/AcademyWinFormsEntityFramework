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
    public partial class Form1 : Form
    {
        public Form1()
        {
            //AddSampleData(); //для додавання даних
            InitializeComponent();
        }
        public void AddDepartment(string name)
        {
            using (var context = new AcademyContext())
            {
                var department = new Department { Name = name };
                context.Departments.Add(department);
                context.SaveChanges();
            }
        }

        public void AddGroup(string name, int departmentId)
        {
            using (var context = new AcademyContext())
            {
                var group = new Group { Name = name, DepartmentId = departmentId };
                context.Groups.Add(group);
                context.SaveChanges();
            }
        }

        public void AddStudent(string firstName, int groupId)
        {
            using (var context = new AcademyContext())
            {
                var student = new Student { FirstName = firstName, GroupId = groupId };
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public void AddForm(string name, int studentId)
        {
            using (var context = new AcademyContext())
            {
                var form = new StudyForm { Name = name, StudentId = studentId };
                context.StudyForms.Add(form);
                context.SaveChanges();
            }
        }
        public void AddSampleData()
        {
            AddDepartment("Інженерія");
            AddDepartment("Програмування");

            AddGroup("А-202", 1); 
            AddGroup("А-404", 2); 

            AddStudent("Студент1", 1);
            AddStudent("Студент2", 2);
            AddStudent("Студент3", 2);
            AddStudent("Студент4", 2);
            AddStudent("Студент5", 2);
            AddStudent("Студент6", 2);
            AddStudent("Студент7", 2);
            AddStudent("Студент8", 1);
            AddStudent("Студент9", 1);
            AddStudent("Студент10", 1);
            AddStudent("Студент11", 1);
            
            AddForm("Заочна", 1);
            AddForm("Напів стаціонар", 2);
            AddForm("Напів стаціонар", 3);
            AddForm("Напів стаціонар", 4);
            AddForm("Заочна", 5);
            AddForm("Заочна", 6);
            AddForm("Заочна", 7);
            AddForm("Заочна", 8);
            AddForm("Заочна", 9);
            AddForm("Заочна", 10);
            AddForm("Напів стаціонар", 11);
        }
        public void LoadDepartmentsData()
        {
            using (var context = new AcademyContext())
            {
                var departments = context.Departments.Select(d => new
                {
                    d.DepartmentId,
                    d.Name
                }).ToList();

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };

                dgv.DataSource = departments;

                TabDepartments.Controls.Clear();
                TabDepartments.Controls.Add(dgv);
            }
        }
        public void LoadGroupsData()
        {
            using (var context = new AcademyContext())
            {
                var groups = context.Groups.Select(g => new
                {
                    g.GroupId,
                    g.Name,
                    DepartmentName = g.Department.Name
                }).ToList();

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };

                dgv.DataSource = groups;

                TabGroups.Controls.Clear();
                TabGroups.Controls.Add(dgv);
            }
        }

        public void LoadFormData()
        {
            using (var context = new AcademyContext())
            {
                var forms = context.StudyForms.Select(f => new
                {
                    IdForm = f.StudyFormId,
                    Name = f.Name,
                    IdStudent = f.StudentId
                }).ToList();

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };

                dgv.DataSource = forms;

                TabForm.Controls.Clear();
                TabForm.Controls.Add(dgv);
            }
        }

        public void LoadStudentsData()
        {
            using (var context = new AcademyContext())
            {
                var students = context.Students.Select(s => new
                {
                    IdStudent = s.StudentId,
                    s.FirstName,
                    s.GroupId
                }).ToList();

                DataGridView dgv = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                };

                dgv.DataSource = students;

                TabStudent.Controls.Clear();
                TabStudent.Controls.Add(dgv);
            }
        }

        private void TabPageDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabPageDB.SelectedTab == TabDepartments)
            {
                LoadDepartmentsData();
            }
            if (TabPageDB.SelectedTab == TabGroups)
            {
                LoadGroupsData();
            }
            if (TabPageDB.SelectedTab == TabForm)
            {
                LoadFormData();
            }
            if (TabPageDB.SelectedTab == TabStudent)
            {
                LoadStudentsData();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (TabPageDB.SelectedTab == TabDepartments)
            {
                LoadDepartmentsData();
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (TabPageDB.SelectedTab == TabDepartments)
            {
                var form = new DepartmentForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    AddDepartment(form.DepartmentName);
                    LoadDepartmentsData();
                }
            }
            if (TabPageDB.SelectedTab == TabGroups)
            {
                var form = new GroupForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    AddGroup(form.GroupName, form.DepartmentId);
                    LoadGroupsData();
                }
            }
            if (TabPageDB.SelectedTab == TabForm)
            {
                var form = new StudyFormForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    AddForm(form.FormName, form.StudentId);
                    LoadFormData();
                }
            }
            if (TabPageDB.SelectedTab == TabStudent)
            {
                var form = new StudentForm();

                if (form.ShowDialog() == DialogResult.OK)
                {
                    AddStudent(form.StudentName, form.GroupId);
                    LoadStudentsData();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            using (var context = new AcademyContext())
            {
                if (TabPageDB.SelectedTab == TabDepartments)
                {
                    var dgv = TabDepartments.Controls.OfType<DataGridView>().FirstOrDefault();
                    if (dgv != null && dgv.SelectedRows.Count > 0)
                    {
                        var departmentId = (int)dgv.SelectedRows[0].Cells["DepartmentId"].Value;
                        var department = context.Departments.FirstOrDefault(d => d.DepartmentId == departmentId);
                        if (department != null)
                        {
                            context.Departments.Remove(department);
                            context.SaveChanges();
                            LoadDepartmentsData();
                        }
                    }
                }
                else if (TabPageDB.SelectedTab == TabGroups)
                {
                    var dgv = TabGroups.Controls.OfType<DataGridView>().FirstOrDefault();
                    if (dgv != null && dgv.SelectedRows.Count > 0)
                    {
                        var groupId = (int)dgv.SelectedRows[0].Cells["GroupId"].Value;
                        var group = context.Groups.FirstOrDefault(g => g.GroupId == groupId);
                        if (group != null)
                        {
                            context.Groups.Remove(group);
                            context.SaveChanges();
                            LoadGroupsData();
                        }
                    }
                }
                else if (TabPageDB.SelectedTab == TabForm)
                {
                    var dgv = TabForm.Controls.OfType<DataGridView>().FirstOrDefault();
                    if (dgv != null && dgv.SelectedRows.Count > 0)
                    {
                        var formId = (int)dgv.SelectedRows[0].Cells["IdForm"].Value;
                        var form = context.StudyForms.FirstOrDefault(f => f.StudyFormId == formId);
                        if (form != null)
                        {
                            context.StudyForms.Remove(form);
                            context.SaveChanges();
                            LoadFormData();
                        }
                    }
                }
                else if (TabPageDB.SelectedTab == TabStudent)
                {
                    var dgv = TabStudent.Controls.OfType<DataGridView>().FirstOrDefault();
                    if (dgv != null && dgv.SelectedRows.Count > 0)
                    {
                        var studentId = (int)dgv.SelectedRows[0].Cells["IdStudent"].Value;
                        var student = context.Students.FirstOrDefault(s => s.StudentId == studentId);
                        if (student != null)
                        {
                            context.Students.Remove(student);
                            context.SaveChanges();
                            LoadStudentsData();
                        }
                    }
                }
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
