﻿using Cwiczenia6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cwiczenia6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Emp> Emps { get; set; }
        public List<Dept> Depts { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
            Example();
        }

        public void LoadData()
        {
            Emps = new List<Emp>();
            Depts = new List<Dept>();

            Emps.Add(new Emp
            {
                Empno = 7369,
                Ename = "SMITH",
                Job = "CLERK",
                Mgr = 7902,
                HireDate = new DateTime(1980, 12, 17),
                Sal=800,
                Comm=0,
                Deptno=20
            });

            Emps.Add(new Emp
            {
                Empno = 7499,
                Ename = "ALLEN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 20),
                Sal = 1600,
                Comm = 300,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7521,
                Ename = "WARD",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 2, 22),
                Sal = 1250,
                Comm = 500,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7566,
                Ename = "JONES",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 4, 2),
                Sal = 2975,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7654,
                Ename = "MARTIN",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 28),
                Sal = 1250,
                Comm = 1400,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7698,
                Ename = "BLAKE",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 5, 1),
                Sal = 2850,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7782,
                Ename = "CLARK",
                Job = "MANAGER",
                Mgr = 7839,
                HireDate = new DateTime(1981, 6, 9),
                Sal = 2450,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7788,
                Ename = "SCOTT",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate = new DateTime(1982, 12, 9),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7839,
                Ename = "KING",
                Job = "PRESIDENT",
                Mgr = null,
                HireDate = new DateTime(1981, 11, 17),
                Sal = 5000,
                Comm = 0,
                Deptno = 10
            });

            Emps.Add(new Emp
            {
                Empno = 7844,
                Ename = "TURNER",
                Job = "SALESMAN",
                Mgr = 7698,
                HireDate = new DateTime(1981, 9, 8),
                Sal = 1500,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7876,
                Ename = "ADAMS",
                Job = "CLERK",
                Mgr = 7788,
                HireDate = new DateTime(1983, 1, 12),
                Sal = 1100,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7900,
                Ename = "JAMES",
                Job = "CLERK",
                Mgr = 7698,
                HireDate = new DateTime(1981, 12, 3),
                Sal = 950,
                Comm = 0,
                Deptno = 30
            });

            Emps.Add(new Emp
            {
                Empno = 7902,
                Ename = "FORD",
                Job = "ANALYST",
                Mgr = 7566,
                HireDate= new DateTime(1981, 12, 3),
                Sal = 3000,
                Comm = 0,
                Deptno = 20
            });

            Emps.Add(new Emp
            {
                Empno = 7934,
                Ename = "MILLER",
                Job = "CLERK",
                Mgr = 7782,
                HireDate = new DateTime(1982, 1, 23),
                Sal = 1300,
                Comm = 0,
                Deptno = 10
            });

            Depts.Add(new Dept
            {
                Deptno=10,
                Dname= "ACCOUNTING",
                Loc= "NEW YORK"
            });

            Depts.Add(new Dept
            {
                Deptno = 20,
                Dname = "RESEARCH",
                Loc = "DALLAS"
            });

            Depts.Add(new Dept
            {
                Deptno = 30,
                Dname = "SALES",
                Loc = "CHICAGO"
            });

            Depts.Add(new Dept
            {
                Deptno = 40,
                Dname = "OPERATIONS",
                Loc = "BOSTON"
            });
        }

        private void Example()
        {
            //Query syntax
            var result = from e in Emps
                         where e.Ename.StartsWith("K")
                         select e;

            //Lambda and Extension methods syntax
            var result2 = Emps.Where(e => e.Ename.StartsWith("K"));


            DataGrid.ItemsSource = result.ToList();
        }

        private void Task1Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { RPensja = emp.Sal * 12 });
            DataGrid.ItemsSource = result.ToList();

        }

        private void Task2Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { EMPLOYEE = emp.Empno + " " + emp.Ename });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task3Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { wynik = $"{emp.Ename} pracuje w dziale {emp.Deptno}" });
            DataGrid.ItemsSource = result.ToList();

        }

        private void Task4Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { rocznapensjacalkowita = emp.Sal * 12 + emp.Comm   });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task5Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { DEPTNO = emp.Deptno });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task6Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new { DEPTNO = emp.Deptno }).Distinct();
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task7Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Select(emp => new {
                DEPTNO = emp.Deptno,
                JOB = emp.Job
            }).Distinct();
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task8Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.OrderBy(emp => emp.Ename);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task9Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.OrderByDescending(emp => emp.HireDate);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task10Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.OrderBy(emp => emp.Deptno).ThenByDescending(emp=>emp.Sal);
            DataGrid.ItemsSource = result.ToList();
        }
        private void Task11Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Job == "CLERK").Select(emp => new {
                Nazwisko = emp.Ename,
                Numer = emp.Empno,
                Stanowisko = emp.Job,
                DepartmentNumber = emp.Deptno
            });

            DataGrid.ItemsSource = result.ToList();

        }

        private void Task12Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp=>emp.Deptno>20);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task13Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Comm > emp.Sal);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task14Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Sal >= 1000 && emp.Sal<=2000);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task15Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Mgr == 7902 || emp.Mgr == 7566 || emp.Mgr == 7788);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task16Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp=>emp.Ename.StartsWith("S"));
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task17Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Ename.Length == 4);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task18Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Mgr==null);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task19Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Sal < 1000 || emp.Sal > 2000);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task20Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => !emp.Ename.StartsWith("M"));
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task21Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Mgr != null);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task22Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Job=="CLERK" && emp.Sal>=1000 && emp.Sal<2000);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task23Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Job == "CLERK" || (emp.Sal >= 1000 && emp.Sal < 2000));
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task24Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => (emp.Job == "MANAGER" && emp.Sal > 1500) ||  emp.Job == "SALESMAN");
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task25Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => (emp.Job == "MANAGER" || emp.Job == "SALESMAN") && emp.Sal >1500);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task26Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp => emp.Job=="MANAGER" || (emp.Job=="CLERK" && emp.Deptno == 10));
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task27Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new {
                EMPNO = emp.Empno,
                DNAME = dept.Dname,
                LOC = dept.Loc
            });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task28Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new {
                ENAME = emp.Ename,
                DNAME = dept.Dname,
            }).OrderBy(emp=>emp.ENAME).ThenBy(emp=>emp.DNAME);
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task29Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new {
                ENAME = emp.Ename,
                DEPTNO = dept.Deptno,
                DNAME = dept.Dname,
            });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task30Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Where(emp=>emp.Sal>1500).Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new {
                ENAME = emp.Ename,
                LOCATION = dept.Loc,
                DNAME = dept.Dname,
            });
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task31Btn_Click(object sender, RoutedEventArgs e)
        {
            var result = Emps.Join(Depts, emp => emp.Deptno, dept => dept.Deptno, (emp, dept) => new {
                ENAME = emp.Ename,
                LOCATION = dept.Loc,
                DNAME = dept.Dname,
            }).Where(emp => emp.LOCATION=="DALLAS");
            DataGrid.ItemsSource = result.ToList();
        }

        private void Task32Btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
