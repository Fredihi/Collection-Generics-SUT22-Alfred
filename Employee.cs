using System;
using System.Collections.Generic;
using System.Text;

namespace Collection_Generics_SUT22_Alfred
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public Employee(int _id, string _name, string _gender, int _salary)
        {
            ID = _id;
            Name = _name;
            Gender = _gender;
            Salary = _salary;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Gender: {0}", Gender);
            Console.WriteLine("Salary: {0}", Salary);
            Console.WriteLine("ID: {0}", ID);
        }
        public override string ToString()
        {
            return $"Name: {Name}\nGender: {Gender}\nSalary: {Salary}\nID: {ID}"; 
        }
    }
}
