using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Collection_Generics_SUT22_Alfred
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(5, "Alfred", "Male", 15000);
            Employee e2 = new Employee(6, "Elmer", "Male", 12000) ;
            Employee e3 = new Employee(7, "Mikaela", "Female", 14000);
            Employee e4 = new Employee(8, "Adam", "Male", 18000);
            Employee e5 = new Employee(9, "Helen", "Female", 16000);

            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(e1); //Push method to add something to the stack
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);

            Console.ForegroundColor = ConsoleColor.Green;

            foreach (Employee employee in stack)
            {
                employee.PrintInfo();
                Console.WriteLine("Amount of items left in stack: {0}",stack.Count);
            }

            Console.WriteLine("--------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;

            while (stack.Count > 0)
            {
                Console.WriteLine("Amount of items left in stack {0}", stack.Count);
                Console.WriteLine(stack.Pop()); //Uses the "Pop" method to output the item at the top of the stack and removes it
            }
            Console.WriteLine("Amount of items left in stack {0}", stack.Count);

            Console.WriteLine("--------------------------------");

            stack.Push(e1);
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);

            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Employee employee in stack)
            {
                Console.WriteLine(stack.Peek()); //Uses the "Peek" method to check what's at the top of the list
            }

            Console.WriteLine("--------------------------------");

            //A new list from the Employee class
            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(e1);
            EmpList.Add(e2);
            EmpList.Add(e3);
            EmpList.Add(e4);
            EmpList.Add(e5);

            Console.ForegroundColor = ConsoleColor.Red;

            //Checks if the "e1" object exists in "EmpList"
            if (EmpList.Contains(e1))
            {
                Console.WriteLine("Object {0} exists in the list", e1);
            }
            else
            {
                Console.WriteLine("Object does not exist in the list");
            }
            Console.WriteLine("--------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("First person with gender Male");
            Console.WriteLine(EmpList.Find(x => x.Gender.Contains("Male"))); //Find the first person that contains "Male"
            
            Console.WriteLine("--------------------------------");
            Console.ForegroundColor = ConsoleColor.White;

            //Makes a new list to save all the variables that contains "Male"
            List<Employee> allMale = EmpList.FindAll(s => s.Gender.Contains("Male"));
            //Outputs all the variables that contains "Male"
            foreach (Employee item in allMale)
            {
                Console.WriteLine("Name: {0}\nGender: {1}\nSalary: {2}\nID: {3}", item.Name, item.Gender, item.Salary, item.ID);
            }

            Console.ReadKey();
        }
    }
}
