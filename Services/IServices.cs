using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Model;

namespace ConsoleApp2.Services
{
    public interface IServices
    {

        void EmployeesList(Employee employee, string TypeOfEmployee);
        void WriteListOfEmployees();
        void RunApplication();
    }
}
