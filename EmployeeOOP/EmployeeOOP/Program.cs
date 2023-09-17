using EmployeeOOP.Classes;

try
{
    int day, month, year, hours;
    string firstName, lastName;
    decimal salary, hourValue, comission, sales, baseValue;

    Console.WriteLine("OOP Application-Web");
    Console.WriteLine("--------------------------\n");

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
    Console.WriteLine("\nSalary Employee:\n");
    Console.WriteLine(salaryEmployee.ToString());

    Console.WriteLine("\n");
}

catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

