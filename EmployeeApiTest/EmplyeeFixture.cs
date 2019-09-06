using System;
using Xunit;
using WebDemo.Controllers;
using WebDemo.Model;

namespace EmployeeApiTest
{
    public class EmplyeeFixture
    {
        EmployeeController employeeController = new EmployeeController();

        Employee employee1 = new Employee()
        {
            Name = "A",
            salary = 40000,
            Designation = "Manager",
            DesignationId = 1
        };

        Employee employee2 = new Employee()
        {
            Name = "B",
            salary = 50000,
            Designation = "Manager",
            DesignationId = 1
        };

        Employee employee3 = new Employee()
        {
            Name = "C",
            salary = 60000,
            Designation = "Manager",
            DesignationId = 1
        };

        Employee employee4 = new Employee()
        {
            Name = "B",
            salary = 40000,
            Designation = "Manager",
            DesignationId = 1
        };

        [Fact]
        public void AddEmployeeInList()
        {
            employeeController.Post(employee1);
            int Expected = EmployeeController.listEmployees[0].id;
            Assert.Equal(1, Expected);
        }

        [Fact]
        public void Is_Get_Working_Properly()
        {
            employeeController.Post(employee2);
            employeeController.Post(employee3);
           
            int Expected = employeeController.Get().Count;
            Assert.Equal(3, Expected);
        }

        [Fact]
        public void Is_Get_With_Paramenter_Working_Properly()
        {
            int Expected = employeeController.Get(1).salary;
            Assert.Equal(40000, Expected);
        }

        [Fact]
        public void Is_Put_With_Paramenter_Working_Properly()
        {
            employeeController.Put(1,employee4);
            int Expected = employeeController.Get(1).salary;
            Assert.Equal(40000, Expected);
        }
    }
}

