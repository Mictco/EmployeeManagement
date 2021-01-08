using System;
using Google.Cloud.Firestore;

namespace EmployeeManager.Shared
{
    [FirestoreData]
    public class Cities
    {
        public string CityName { get; set; }
    }
}
