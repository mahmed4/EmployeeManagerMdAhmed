﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManager.Models
{
    public class CreateEmployeeModel
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public double Salary { get; set; }
        public Guid EmployeeId { get; set; }
        public double AvailableHours { get; set; }
    }
}