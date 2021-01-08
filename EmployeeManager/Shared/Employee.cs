using System;
using System.ComponentModel.DataAnnotations;
using Google.Cloud.Firestore;

namespace EmployeeManager.Shared
{
    [FirestoreData]
    public class Employee
    {
        public string EmployeeId { get; set; }
        public DateTime date { get; set; }
        [FirestoreProperty]
        [Required]
        public string EmployeeName { get; set; }
        [FirestoreProperty]
        [Required]
        public string CityName { get; set; }
        [FirestoreProperty]
        [Required]
        public string Designation { get; set; }
        [FirestoreProperty]
        [Required]
        public string Gender { get; set; }
    }
}
