using System;
using System.ComponentModel.DataAnnotations;
using Google.Cloud.Firestore;

namespace EmployeeManager.Shared
{
    [FirestoreData]
    public class WorkDetails
    {
        public int Id { get; set; }
        [FirestoreProperty]
        [Required]
        public string Name { get; set; }
        [FirestoreProperty]
        [Required]
        public string Company { get; set; }
        [FirestoreProperty]
        [Required]
        public string PriorityStatus { get; set; }
        [FirestoreProperty]
        public int WorkReceivedBy { get; set; }
        [FirestoreProperty]
        public DateTime DateWorkReceived { get; set; }
        [FirestoreProperty]
        public string TimeWorkReceived { get; set; }
        [FirestoreProperty]
        public DateTime DateWorkAlotted { get; set; }
        [FirestoreProperty]
        public string TimeWorkAlotted { get; set; }
        [FirestoreProperty]
        public int AlotedBy { get; set; }
        [FirestoreProperty]
        public int EmployeeId { get; set; }
        [FirestoreProperty]
        public string ReceiverNote { get; set; }
        [FirestoreProperty]
        public string AlottedNote { get; set; }
        [FirestoreProperty]
        public DateTime DateWorkStarted { get; set; }
        [FirestoreProperty]
        public string TimeWorkStarted { get; set; }
        [FirestoreProperty]
        public DateTime DateEstimateToComplete { get; set; }
        [FirestoreProperty]
        public string TimeEstimationToComplete { get; set; }
        [FirestoreProperty]
        public string StartedNotes { get; set; }
        [FirestoreProperty]
        public DateTime DateCompleted { get; set; }
        [FirestoreProperty]
        public string TimeCompleted { get; set; }
        [FirestoreProperty]
        public string CompletedNotes { get; set; }
        [FirestoreProperty]
        public string Remarks { get; set; }
        [FirestoreProperty]
        public decimal TimeTaken { get; set; }

    }

}
