using System;
using System.ComponentModel.DataAnnotations;
using Google.Cloud.Firestore;

namespace EmployeeManager.Shared
{
    [FirestoreData]
    public class Employee
    {
        public string EmployeeId { get; set; }
        [FirestoreProperty]
        [Required]
        public string EmployeeName { get; set; }
        [FirestoreProperty]
        [Required]
        public string Company { get; set; }
        [FirestoreProperty]
        [Required]
        public string JobType { get; set; }
        [FirestoreProperty]
        [Required]
        public bool IsActive { get; set; }
        [FirestoreProperty]
        [Required]
        public string Password { get; set; }

    }
}
