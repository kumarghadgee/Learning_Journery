using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace _01_DemoCrudOperations
{
    public class EmpMenu
    {
        public void Menu()
        {
            int choice;
            do
            {
                Console.WriteLine("0.Exit.");
                Console.WriteLine("1.Get Data.");
                Console.WriteLine("2.Add Data.");
                Console.WriteLine("3.Update Data.");
                Console.WriteLine("4.Delete Data.");
                Console.Write("Enter Your Choice :");
                choice = int.Parse(Console.ReadLine());

                EmpOps empOps = new EmpOps();
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("You Entered ('0') Terminating.....");
                        break;

                    case 1:
                        var emps = empOps.GetData();
                        foreach (var e in emps)
                        {
                            Console.WriteLine($"No : {e.No}, Name : {e.Name}, Address : {e.Address}");
                        }
                        break;

                    case 2:
                        empOps.AddData();
                        break;

                    case 3:
                        empOps.UpdateData();
                        break;

                    case 4:
                        empOps.DeleteData();
                        break;

                    default:
                        Console.WriteLine("Entered Wrong Input....");
                        break;
                }
            } while (choice != 0);
            
        }
    }
}
