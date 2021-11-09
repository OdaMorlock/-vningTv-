using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.Services
{
    public class Services : IServices
    {
        List<Employee> employees = new List<Employee>();
        
        Employee employee = new Employee();

        ResultWithWord Result = new ResultWithWord();


        public void EmployeesList(Employee employee,string TypeOfEmployee)
        {
            try
            {
                if (TypeOfEmployee == "CannonFodder")
                {
                    employee.TotalSalery = -100;
                }
                if (TypeOfEmployee == "Grunt")
                {
                    employee.TotalSalery = employee.BaseSalery;
                }
                if (TypeOfEmployee == "Veteran")
                {
                    employee.TotalSalery = employee.BaseSalery + 100;
                }
                if (TypeOfEmployee == "Elite")
                {
                    employee.TotalSalery = employee.BaseSalery * 10;
                }
                if (TypeOfEmployee != "CannonFodder" && TypeOfEmployee == "Grunt" && TypeOfEmployee == "Veteran" && TypeOfEmployee == "Elite")
                {
                    employee.TotalSalery = 0;
                }

                var _employee = new Employee
                {
                    FistName = employee.FistName,
                    LastName = employee.LastName,
                    BaseSalery = employee.BaseSalery,
                    TotalSalery = employee.TotalSalery
                };
                employees.Add(_employee);
            }
            catch (Exception)
            {

                
            }
            

        }

       

        public void WriteListOfEmployees()
        {
            try
            {
                foreach (var item in employees)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine($"Employee FirstName: {item.FistName}  Employee LastName: {item.LastName}");
                    Console.WriteLine($"BaseSalery: {item.BaseSalery}");
                    Console.WriteLine($"Total Salery: {item.TotalSalery}");
                    Console.WriteLine(" ");
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public void RunApplication()
        {
            bool Active = true;


            try
            {

                while (Active == true)
                {
                    Console.WriteLine("If you wanna add an employee Type Add");
                    Console.WriteLine("If you wanna View List Type View");
                    Console.WriteLine("If you wanna Exit the Program type Exit");
                    var Option = Console.ReadLine();

                       

                        if (Option == "Exit")
                        {
                            Active = false;
                        }

                        // Too Add an Employee
                        if (Option == "Add")
                        {
                            Console.WriteLine("FirstName");
                            employee.FistName = Console.ReadLine();

                            Console.WriteLine("LastName");
                            employee.LastName = Console.ReadLine();

                            Console.WriteLine("BaseSalery");
                            employee.BaseSalery = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Type Of Employee: CannonFodder . Grunt . Veteran . Elite");
                            var TypeOfEmployee = Console.ReadLine();



                            //If the TypeOfEmployee is not one of the options.
                            if (TypeOfEmployee != "CannonFodder" && TypeOfEmployee == "Grunt" && TypeOfEmployee == "Veteran" && TypeOfEmployee == "Elite")
                            {
                                Console.WriteLine($"{TypeOfEmployee} Is an Invalide Type Try Again");
                                Console.ReadLine();

                                if (TypeOfEmployee != "CannonFodder" && TypeOfEmployee == "Grunt" && TypeOfEmployee == "Veteran" && TypeOfEmployee == "Elite")
                                {
                                    Console.WriteLine("Exiting Program");
                                    Environment.Exit(0);
                                }
                            }

                            Console.WriteLine($"{employee.FistName} {employee.LastName} {employee.BaseSalery} {TypeOfEmployee}");

                            EmployeesList(employee, TypeOfEmployee);
                        }
                        if (Option == "View")
                        {
                            WriteListOfEmployees();

                        }
                        if (Option != "Exit" && Option != "Add" && Option != "View")
                        {
                            Console.WriteLine($"Invalid Option {Option}");
                        }


                }

            
            }
            catch (Exception)
            {

                throw;
            }


           




        }

        
    }
}
