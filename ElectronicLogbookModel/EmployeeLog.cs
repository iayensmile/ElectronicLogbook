﻿using System;
using BaseModel;
using System.ComponentModel.DataAnnotations;

namespace ElectronicLogbookModel
{
    public class EmployeeLog : Base
    {
        public bool SuccesLogin { get; set; }
        public DateTime LogDate { get; set; }
        public int EmployeeLogId { get; set; }
        public int EmployeeId { get; set; }
        public int LogTypeId { get; set; }
        [Required, Display(Name = "Employee Number"), StringLength(100)]
        public string EmployeeNumber { get; set; }
        public string EmployeeImageBase64 { get; set; }
        public string LogName { get; set; }
        [Required, Display(Name = "Pin"), DataType(DataType.Password), StringLength(100)]
        public string Pin { get; set; }
        public LogType LogType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
