
////Without using Delegate
//class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();
//        empList.Add(new Employee() { Id=101,Name="Mary",Salary = 5000,Experience=5});
//        empList.Add(new Employee() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });
//        Employee.PromoteEmploye(empList);
//    }

//}

//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Salary {  get; set; }
//    public int Experience {  get; set; }

//    public static void PromoteEmploye(List<Employee> empList)
//    {
//        foreach (Employee emp in empList) {
//            if (emp.Experience >= 5)
//            {
//                Console.WriteLine(emp.Name + " Promoted");
//            }        
//        }
//    }
//}



////With using Delegate
//class Program
//{
//    public static void Main()
//    {
//        List<Employee> empList = new List<Employee>();
//        empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
//        empList.Add(new Employee() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
//        empList.Add(new Employee() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
//        empList.Add(new Employee() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });

//        IsPromoteable isPromoteable = new IsPromoteable(Promote);
//        Employee.PromoteEmploye(empList,isPromoteable);
//    }
//    public static bool Promote(Employee emp)
//    {
//        if (emp.Experience >= 5)
//        {
//            return true;
//        }else
//        {
//            return false;
//        }
//    }
//}
//delegate bool IsPromoteable(Employee emp1);
//class Employee
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public int Salary { get; set; }
//    public int Experience { get; set; }

//    public static void PromoteEmploye(List<Employee> empList , IsPromoteable IsEligibleToPromote)
//    {
//        foreach (Employee emp in empList)
//        {
//            if (IsEligibleToPromote(emp))
//            {
//                Console.WriteLine(emp.Name + " Promoted");
//            }
//        }
//    }
//}


//With using Delegate & Lambda Expression
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name = "Mary", Salary = 5000, Experience = 5 });
        empList.Add(new Employee() { Id = 102, Name = "Mike", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { Id = 103, Name = "John", Salary = 6000, Experience = 6 });
        empList.Add(new Employee() { Id = 104, Name = "Todd", Salary = 3000, Experience = 3 });

        
        Employee.PromoteEmploye(empList, emp=> emp.Experience>=5);
    }
    
}
delegate bool IsPromoteable(Employee emp1);
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void PromoteEmploye(List<Employee> empList, IsPromoteable IsEligibleToPromote)
    {
        foreach (Employee emp in empList)
        {
            if (IsEligibleToPromote(emp))
            {
                Console.WriteLine(emp.Name + " Promoted");
            }
        }
    }
}