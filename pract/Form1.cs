using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace pract
{
    public partial class Form1 : Form
    {
        public class Employee
        {
            public int ID { get; set; }
            public string FIO { get; set; }
            public string Position { get; set; }
            public decimal Salary { get; set; }
        }
        private List<Employee> Company = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            DisplayEmployees(Company, "Начальный список сотрудников");
        }

        private void InitializeData()
        {
            Company.Add(new Employee { ID = 1, FIO = "Махотина А.", Position = "Инженер", Salary = 38000 });
            Company.Add(new Employee { ID = 2, FIO = "Гуськов Б.", Position = "Менеджер", Salary = 45000 });
            Company.Add(new Employee { ID = 3, FIO = "Луценко А.", Position = "Директор", Salary = 60000 });
            Company.Add(new Employee { ID = 4, FIO = "Кемаев А.", Position = "Инженер", Salary = 38000 });
            Company.Add(new Employee { ID = 5, FIO = "Антонова С.", Position = "Менеджер", Salary = 40000 });
        }

        private void DisplayEmployees(List<Employee> list, string title)
        {
            listBoxLog.Items.Add($"=== {title} ===");
            foreach (var emp in list)
            {
                listBoxLog.Items.Add($"ID: {emp.ID}, ФИО: {emp.FIO}, Должность: {emp.Position}, Зарплата: {emp.Salary}");
            }
            listBoxLog.Items.Add("");
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            var newEmp = new Employee { ID = 6, FIO = "Семенов Б.", Position = "Менеджер", Salary = 58000 };
            int index = Company.FindIndex(emp => emp.ID == 3);
            if (index >= 0)
            {
                Company.Insert(index, newEmp);
                DisplayEmployees(Company, "После вставки перед ID=3");
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var empToRemove = Company.Find(emp => emp.ID == 4);
            if (empToRemove != null)
            {
                Company.Remove(empToRemove);
                DisplayEmployees(Company, "После удаления ID=4");
            }
        }

        private void buttonFindManagers_Click(object sender, EventArgs e)
        {
            var managers = Company.FindAll(emp => emp.Position == "Менеджер");
            DisplayEmployees(managers, "Менеджеры");
        }

        private void buttonSortSalary_Click(object sender, EventArgs e)
        {
            var sorted = Company.OrderBy(emp => emp.Salary).ThenBy(emp => emp.FIO).ToList();
            DisplayEmployees(sorted, "Сортировка по зарплате и ФИО");
        }

        private void buttonFindManagers_Click_1(object sender, EventArgs e)
        {
            var managers = Company.FindAll(emp => emp.Position == "Менеджер");
            DisplayEmployees(managers, "Менеджеры");
        }

        private void buttonRemove_Click_1(object sender, EventArgs e)
        {
            var empToRemove = Company.Find(emp => emp.ID == 4);
            if (empToRemove != null)
            {
                Company.Remove(empToRemove);
                DisplayEmployees(Company, "После удаления ID=4");
            }
        }
        private void buttonInsert_Click_1(object sender, EventArgs e)
        {
            var newEmp = new Employee { ID = 6, FIO = "Семенов Б.", Position = "Менеджер", Salary = 58000 };
            int index = Company.FindIndex(emp => emp.ID == 3);
            if (index >= 0)
            {
                Company.Insert(index, newEmp);
                DisplayEmployees(Company, "После вставки перед ID=3");
            }
        }
    }
}
//Программу написал Голов Александр 23ИС