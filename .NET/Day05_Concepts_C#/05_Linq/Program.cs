namespace _05_Linq
{
    public class Emp
    {
        public int EmpId { get; set; }
        public string Ename { get; set; }
        public string Job { get; set; }
        public int? ManagerId { get; set; }
        public DateTime Hire { get; set; }
        public double Salary { get; set; }
        public double? Commission { get; set; }
        public int DeptId { get; set; }

        public override string ToString()
        {
            return $"Emp -> Id: {EmpId}, Name: {Ename}, Job: {Job}, Manager: {ManagerId}, Hire: {Hire.ToShortDateString()}, Salary: {Salary}, Comm: {Commission}, Dept: {DeptId}";
        }
    }
    public class Dept
    {
        public int DeptId { get; set; }
        public string Dname { get; set; }
        public string Location { get; set; }
        public override string ToString()
        {
            return $"Dept -> Id: {DeptId}, Name: {Dname}, Location: {Location}";
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            List<Emp> emps = new List<Emp>
            {
                new Emp { EmpId = 7369, Ename = "SMITH", Job = "CLERK", ManagerId = 7902, Hire = DateTime.Parse("1980-12-17"), Salary = 800.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7499, Ename = "ALLEN", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-02-20"), Salary = 1600.00, Commission = 300.00, DeptId = 30 },
                new Emp { EmpId = 7521, Ename = "WARD", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-02-22"), Salary = 1250.00, Commission = 500.00, DeptId = 30 },
                new Emp { EmpId = 7566, Ename = "JONES", Job = "MANAGER", ManagerId = 7839, Hire = DateTime.Parse("1981-04-02"), Salary = 2975.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7654, Ename = "MARTIN", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-09-28"), Salary = 1250.00, Commission = 1400.00, DeptId = 30 },
                new Emp { EmpId = 7698, Ename = "BLAKE", Job = "MANAGER", ManagerId = 7839, Hire = DateTime.Parse("1981-05-01"), Salary = 2850.00, Commission = null, DeptId = 30 },
                new Emp { EmpId = 7782, Ename = "CLARK", Job = "MANAGER", ManagerId = 7839, Hire = DateTime.Parse("1981-06-09"), Salary = 2450.00, Commission = null, DeptId = 10 },
                new Emp { EmpId = 7788, Ename = "SCOTT", Job = "ANALYST", ManagerId = 7566, Hire = DateTime.Parse("1982-12-09"), Salary = 3000.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7839, Ename = "KING", Job = "PRESIDENT", ManagerId = null, Hire = DateTime.Parse("1981-11-17"), Salary = 5000.00, Commission = null, DeptId = 10 },
                new Emp { EmpId = 7844, Ename = "TURNER", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-09-08"), Salary = 1500.00, Commission = 0.00, DeptId = 30 },
                new Emp { EmpId = 7876, Ename = "ADAMS", Job = "CLERK", ManagerId = 7788, Hire = DateTime.Parse("1983-01-12"), Salary = 1100.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7900, Ename = "JAMES", Job = "CLERK", ManagerId = 7698, Hire = DateTime.Parse("1981-12-03"), Salary = 950.00, Commission = null, DeptId = 30 },
                new Emp { EmpId = 7902, Ename = "FORD", Job = "ANALYST", ManagerId = 7566, Hire = DateTime.Parse("1981-12-03"), Salary = 3000.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7934, Ename = "MILLER", Job = "CLERK", ManagerId = 7782, Hire = DateTime.Parse("1982-01-23"), Salary = 1300.00, Commission = null, DeptId = 10 }
            };

            List<Dept> depts = new List<Dept>
            {
                new Dept { DeptId = 10, Dname = "Accounting", Location = "New York" },
                new Dept { DeptId = 20, Dname = "Research", Location = "Dallas" },
                new Dept { DeptId = 30, Dname = "Sales", Location = "Chicago" },
                new Dept { DeptId = 40, Dname = "Operations", Location = "Boston" }
            };

            var empresult = from e 
                      in emps
                      select e;

            //foreach(var e in empresult)
            //{
            //    Console.WriteLine(e);
            //}

            Console.WriteLine("````````````````````````````````````````````````````````````````````````````````````");

            var empres = from e
                         in emps
                         where e.Salary > 2000
                         select e;

            //foreach(var emp in empres)
            //{
            //    Console.WriteLine(emp);
            //}

            var eprr = from e
                       in emps
                       orderby e.Salary descending
                       select e;

            //foreach(var em in eprr)
            //{
            //    Console.WriteLine(em);
            //}

            var ep = from e
                     in emps
                     orderby e.Ename ascending
                     where e.Salary > 2000
                     select e;

            //foreach(var m in ep)
            //{
            //    Console.WriteLine(m);
            //}

            var dept = from d
                       in depts
                       where d.DeptId == 10 
                       orderby d.Dname descending
                       select d;

            //foreach(var d in dept)
            //{
            //    Console.WriteLine(d);
            //}

            var re = from e
                     in emps
                     where e.Salary < 3700
                     orderby e.EmpId ascending
                     select e;
            var res = re.Take(3);

            foreach(var m in res)
            {
                Console.WriteLine(m);
            }
        }

        static void Main(string[] args)
        {
            List<Emp> emps = new List<Emp>
            {
                new Emp { EmpId = 7369, Ename = "SMITH", Job = "CLERK", ManagerId = 7902, Hire = DateTime.Parse("1980-12-17"), Salary = 800.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7499, Ename = "ALLEN", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-02-20"), Salary = 1600.00, Commission = 300.00, DeptId = 30 },
                new Emp { EmpId = 7521, Ename = "WARD", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-02-22"), Salary = 1250.00, Commission = 500.00, DeptId = 30 },
                new Emp { EmpId = 7566, Ename = "JONES", Job = "MANAGER", ManagerId = 7839, Hire = DateTime.Parse("1981-04-02"), Salary = 2975.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7654, Ename = "MARTIN", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-09-28"), Salary = 1250.00, Commission = 1400.00, DeptId = 30 },
                new Emp { EmpId = 7698, Ename = "BLAKE", Job = "MANAGER", ManagerId = 7839, Hire = DateTime.Parse("1981-05-01"), Salary = 2850.00, Commission = null, DeptId = 30 },
                new Emp { EmpId = 7782, Ename = "CLARK", Job = "MANAGER", ManagerId = 7839, Hire = DateTime.Parse("1981-06-09"), Salary = 2450.00, Commission = null, DeptId = 10 },
                new Emp { EmpId = 7788, Ename = "SCOTT", Job = "ANALYST", ManagerId = 7566, Hire = DateTime.Parse("1982-12-09"), Salary = 3000.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7839, Ename = "KING", Job = "PRESIDENT", ManagerId = null, Hire = DateTime.Parse("1981-11-17"), Salary = 5000.00, Commission = null, DeptId = 10 },
                new Emp { EmpId = 7844, Ename = "TURNER", Job = "SALESMAN", ManagerId = 7698, Hire = DateTime.Parse("1981-09-08"), Salary = 1500.00, Commission = 0.00, DeptId = 30 },
                new Emp { EmpId = 7876, Ename = "ADAMS", Job = "CLERK", ManagerId = 7788, Hire = DateTime.Parse("1983-01-12"), Salary = 1100.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7900, Ename = "JAMES", Job = "CLERK", ManagerId = 7698, Hire = DateTime.Parse("1981-12-03"), Salary = 950.00, Commission = null, DeptId = 30 },
                new Emp { EmpId = 7902, Ename = "FORD", Job = "ANALYST", ManagerId = 7566, Hire = DateTime.Parse("1981-12-03"), Salary = 3000.00, Commission = null, DeptId = 20 },
                new Emp { EmpId = 7934, Ename = "MILLER", Job = "CLERK", ManagerId = 7782, Hire = DateTime.Parse("1982-01-23"), Salary = 1300.00, Commission = null, DeptId = 10 }
            };

            List<Dept> depts = new List<Dept>
            {
                new Dept { DeptId = 10, Dname = "Accounting", Location = "New York" },
                new Dept { DeptId = 20, Dname = "Research", Location = "Dallas" },
                new Dept { DeptId = 30, Dname = "Sales", Location = "Chicago" },
                new Dept { DeptId = 40, Dname = "Operations", Location = "Boston" }
            };

            var res = emps.Where(e => e.Salary>2000 );
            //foreach(var e in res)
            //{
            //    Console.WriteLine(e);
            //}

            var re2 = emps.Where(e => e.Salary > 2000).OrderByDescending(e => e.Ename);
            //foreach (var e in re2)
            //{
            //    Console.WriteLine(e);
            //}

            var res3 = depts.Where(d => d.DeptId < 50);
            //foreach(var d in res3)
            //{
            //    Console.WriteLine(d);
            //}

            var res4 = depts.OrderByDescending(d => d.Dname);
            foreach(var em in res4)
            {
                Console.WriteLine(em);
            }
        }

    }
}