﻿using System;

namespace Assignment2OOP
{
    // ---------------------------  Part1  ---------------------------

    #region indexer
    // indexer is a special Property: 
    //   - indexer allows instances of a class or struct to be indexed just like arrays.
    //   - It enables objects to be treated like arrays for retrieval and setting of elements.
    //   - Indexers are defined using special "this" keyword.
    //   - Indexers can take Parameters.

    //public returnType this[indexer parameters] //Indexers are defined using special "this" keyword 
    //{
    //    get
    //    {
    //        // Return value based on indexer parameters
    //    }
    //    set
    //    {
    //        // Set value based on indexer parameters
    //    }
    //}
    #endregion

    #region class

    #region simple example of class
    //// simple example for class
    //public class Car
    //{
    //    // Attributes
    //    private string make;
    //    private string model;
    //    private int year;

    //    // Properties
    //    public string Make
    //    {
    //        get { return make; }
    //        set { make = value; }
    //    }

    //    public string Model
    //    {
    //        get { return model; }
    //        set { model = value; }
    //    }

    //    public int Year
    //    {
    //        get { return year; }
    //        set
    //        {
    //            if (value > 1885) // The first car was made in 1886
    //                year = value;
    //        }
    //    }

    //    // Constructor
    //    public Car(string make, string model, int year)
    //    {
    //        this.make = make;
    //        this.model = model;
    //        this.year = year;
    //    }

    //    // Method
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Car: {year} {make} {model}");
    //    }
    //} 
    #endregion

    #region Constructor Chaining
    // constructor chaining => the practice of calling one constructor from another constructor within the same class or from a base class constructor.
    // This technique allows you to avoid code duplication and create a clear, organized flow of initialization logic.
    //public class Car
    //{
    //    #region Attributes
    //    private int id;

    //    private string model;

    //    private double speed;
    //    #endregion

    //    #region Properties
    //    public double Speed
    //    {
    //        get { return speed; }
    //        set { speed = value; }
    //    }

    //    public string Model
    //    {
    //        get { return model; }
    //        set { model = value; }
    //    }

    //    public int ID
    //    {
    //        get { return id; }
    //        set { id = value; }
    //    }
    //    #endregion




    //    // Constructor
    //    public Car(int _id, string _model, double _Speed)
    //    {
    //        id = _id;
    //        model = _model;
    //        speed = _Speed;
    //    }

    //    public Car(int _id, string _model) : this(_id, _model, 180) {  }

    //    public Car(int _id) : this(_id, "BMW", 280) {  }
    //}
    #endregion

    #endregion

    #region inheritance
    // inheritance => allows one class (the derived or child class) to inherit the properties and methods of another class (the base or parent class).
    // This promotes code reuse, logical hierarchy, and the ability to extend existing code without modification.

    //public class BaseClass
    //{
    //    // Base class members
    //}

    //public class DerivedClass : BaseClass
    //{
    //    // Derived class members
    //}
    #endregion

    #region Access Modifiers
    //Access modifiers in C# control the visibility and accessibility of classes, methods, properties, fields, and other members within the code.

    // 1. private: Access only within the same class.
    // 2. private protected: Access within the same class and derived classes within the same assembly.
    // 3. protected: Access within the same class and derived classes.
    // 4. internal: Access within the same assembly.
    // 5. protected internal: Access within the same assembly and derived classes.
    // 6. public: Access from anywhere.
    #endregion


    // ---------------------------  Part2  ---------------------------
    // 1. Design and implement a Class for the employees in a company:
    //    Employee is identified by an ID, Name, security level, salary, hire date and Gender.
    #region Q1
    //public class Employee
    //{
    //    #region Employee Attributes
    //    //public int id { get; set; }
    //    //public string name { get; set; }
    //    //public decimal salary { get; set; }
    //    //public HiringDate hireDate { get; set; }
    //    //private string gender;
    //    //private SecurityLevel securityLevel;

    //    #endregion

    //    #region Employee Properties
    //    //public string Gender
    //    //{
    //    //    get { return gender; }
    //    //    set
    //    //    {
    //    //        if (value == "M" || value == "F")
    //    //        {
    //    //            gender = value;
    //    //        }
    //    //        else
    //    //        {
    //    //            Console.WriteLine("Gender must be either 'M' or 'F'.");
    //    //        }
    //    //    }
    //    //}

    //    //public SecurityLevel SecurityLevel
    //    //{
    //    //    get { return securityLevel; }
    //    //    set { securityLevel = value; }
    //    //}

    //    #endregion

    //    #region Employee Methods
    //    //public Employee(int _id, string _name, decimal _salary, string _gender, SecurityLevel _securityLevel, HiringDate _hireDate)
    //    //{
    //    //    id = _id;
    //    //    name = _name;
    //    //    salary = _salary;
    //    //    gender = _gender;
    //    //    securityLevel = _securityLevel;
    //    //    hireDate = _hireDate;
    //    //}

    //    //public override string ToString()
    //    //{
    //    //    return string.Format("\nID: {0}\nName: {1}\nGender: {2}\nSecurity Level: {3}\nSalary: {4:C}\nHire Date: {5}\n", id, name, gender, securityLevel, salary, hireDate);
    //    //}
    //    #endregion
    //} 
    #endregion

    // 2. Develop a Class to represent the Hiring Date Data:
    //    consisting of fields to hold the day, month and Years.
    #region Q2
    //public class HiringDate
    //{
    //    #region HiringDate Attributes
    //    //public int day;
    //    //public int month;
    //    //public int year;
    //    #endregion

    //    #region HiringDate Methods
    //    //public HiringDate(int _day, int _month, int _year)
    //    //{
    //    //    day = _day;
    //    //    month = _month;
    //    //    year = _year;
    //    //}

    //    //public override string ToString()
    //    //{
    //    //    return $"{day}/{month}/{year}";
    //    //}
    //    #endregion
    //}
    #endregion

    // 3. We need to restrict the Gender field to be only M or F[Male or Female]
    #region Q3
    // the answer in class Employee 
    #endregion

    // 4. Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
    #region Q4
    //[Flags]
    //public enum SecurityLevel : byte
    //{
    //    Guest = 1,
    //    Developer = 2,
    //    Secretary = 4,
    //    DBA = 8
    //}
    #endregion

    // 5. We want to provide the Employee Class to represent Employee data in a string Form(override ToString ()), display employee salary in a currency format. [use String.Format Function]
    #region Q5
    // the answer in class Employee  
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee[] EmpArr;)
            #region Q6
            //Employee[] EmpArr = new Employee[3];

            //SecurityLevel SecurityOfficer = SecurityLevel.DBA | SecurityLevel.Guest | SecurityLevel.Developer | SecurityLevel.Secretary;

            //EmpArr[0] = new Employee(1, "Alice", 80000m, "F", SecurityLevel.DBA, new HiringDate(12, 5, 2015));
            //EmpArr[1] = new Employee(2, "Bob", 30000m, "M", SecurityLevel.Guest, new HiringDate(1, 9, 2020));
            //EmpArr[2] = new Employee(3, "Charlie", 90000m, "M", SecurityOfficer, new HiringDate(20, 3, 2010));

            //foreach (Employee emp in EmpArr)
            //{
            //    Console.WriteLine(emp);
            //} 
            #endregion
        }
    } 
}
