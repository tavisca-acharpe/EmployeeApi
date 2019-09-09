using System;
using Xunit;
using WebDemo.Controllers;
using WebDemo.Model;

namespace EmployeeApiTest
{
    [Collection("Sequential")]
    public class EmplyeeFixture
    { 
        Employee employee1 = new Employee()
        {
            Name = "A",
            salary = 40000,
            Designation = "Manager",
            TeamId = 1
        };

        Employee employee2 = new Employee()
        {
            Name = "B",
            salary = 50000,
            Designation = "Manager",
            TeamId = 1
        };

        Employee employee3 = new Employee()
        {
            Name = "C",
            salary = 60000,
            Designation = "Manager",
            TeamId = 1
        };

        Employee employee4 = new Employee()
        {
            Name = "D",
            salary = 60000,
            Designation = "Manager",
            TeamId = 1
        };

        public void DataInitalize(EmployeeController employeeController)
        {
            employeeController.Post(employee1);
            employeeController.Post(employee2);
            employeeController.Post(employee3);
        }

        [Fact]
        public void Is_Get_Working_Properly()
        {
            EmployeeController employeeController1 = new EmployeeController();
            DataInitalize(employeeController1);
            int Expected = employeeController1.Get().Count;
            Assert.Equal(3, Expected);
        }

        [Fact]
        public void Is_Get_With_Paramenter_Working_Properly()
        {
            EmployeeController employeeController2 = new EmployeeController();
            DataInitalize(employeeController2);
            int Expected = employeeController2.Get(2).salary;
            Assert.Equal(50000, Expected);
        }

        [Fact]
        public void Is_Put_With_Paramenter_Working_Properly()
        {
            EmployeeController employeeController3 = new EmployeeController();
            DataInitalize(employeeController3);
            employeeController3.Put(2,employee4);
            int Expected = employeeController3.Get(2).salary;
            Assert.Equal(60000, Expected);
        }

        [Fact]
        public void Is_Delete_With_Paramenter_Working_Properly()
        {
            EmployeeController employeeController = new EmployeeController();
            DataInitalize(employeeController);
            employeeController.Delete(2);
            int Expected = employeeController.Get().Count;
            Assert.Equal(2, Expected);
        }      
    }
}

