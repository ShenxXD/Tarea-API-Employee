﻿//TAREA 5% = Clases Comission, BaseComission, Hourly...
//NOMBRE: Angie Londoño Hernández 
//GRUPO: Sábados 2:00-4:00PM 

using EmployeeOOP.Classes;

try
{
    int day, month, year, hours;
    string firstName, lastName;
    decimal salary, hourValue, comission, sales, baseV;

    Console.WriteLine("OOP APP-WEB");
    Console.WriteLine("------------------------------\n");

    Console.Write("Ingresar el día: ");
    day = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el mes: ");
    month = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ingresar el año: ");
    year = Convert.ToInt32(Console.ReadLine());

    Date dateObject = new Date(day, month, year);
    Console.WriteLine("\n");
    Console.WriteLine(dateObject.ToString());


    Console.Write("Ingresar nombre completo: ");
    firstName = Console.ReadLine();

    Console.Write("Ingresar apellidos: ");
    lastName = Console.ReadLine();


    //Salary Employee

    Console.Write("Ingresar salario: ");
    salary = Decimal.Parse(Console.ReadLine());

    SalaryEmployee salaryEmployee = new SalaryEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Salary = salary,
    };
   
    Console.WriteLine("\n");
    Console.WriteLine(salaryEmployee.ToString());



    //Hourly Employee

    Console.Write("Ingresar horas trabajadas: ");
    hours = Int32.Parse(Console.ReadLine());

    Console.Write("Ingresar valor por hora: ");
    hourValue = Decimal.Parse(Console.ReadLine());

    HourlyEmployee hourlyEmployee = new HourlyEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        HourV = hourValue,
        Hours = hours,
    };

    
    Console.WriteLine("\n");
    Console.WriteLine(hourlyEmployee.ToString());

    Console.WriteLine("\n");



    //Comission Employee

    Console.Write("Ingresar porcentaje de comision: ");
    comission = Decimal.Parse(Console.ReadLine());

    Console.Write("Ingresar valor de ventas: ");
    sales = Decimal.Parse(Console.ReadLine());

    ComissionEmployee comissionEmployee = new ComissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        ComissionPercentaje = comission,
    };


    Console.WriteLine("\n");
    Console.WriteLine(comissionEmployee.ToString());

    Console.WriteLine("\n");


    //BaseComission Employee

    Console.Write("Ingresar pago base: ");
    baseV = Decimal.Parse(Console.ReadLine());

    BaseComissionEmployee baseComissionEmployee = new BaseComissionEmployee()
    {
        Id = 123456,
        FirstName = firstName,
        lastName = lastName,
        BirthDate = dateObject,
        HiringDate = dateObject,
        IsActive = true,
        Sales = sales,
        ComissionPercentaje = comission,
        BaseC = baseV,
    };

  
    Console.WriteLine("\n");
    Console.WriteLine(baseComissionEmployee.ToString());

 

    Console.WriteLine("\n");
}

catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

