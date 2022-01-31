﻿namespace EmployeeManagement.Models
{



    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        public Department Department { get; set; } = new Department();
        public string PhotoPath { get; set; } = string.Empty;
    }
}