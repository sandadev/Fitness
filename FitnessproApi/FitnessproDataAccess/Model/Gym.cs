//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitnessproDataAccess.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Gym
    {
        public int GymId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GymName { get; set; }
        public Nullable<long> MobileNumber { get; set; }
        public Nullable<long> TelephoneNumber { get; set; }
        public Nullable<System.DateTime> EnrolledDate { get; set; }
        public string Email { get; set; }
        public Nullable<int> EstablishedYear { get; set; }
        public Nullable<int> ServiceId { get; set; }
    
        public virtual Service Service { get; set; }
    }
}