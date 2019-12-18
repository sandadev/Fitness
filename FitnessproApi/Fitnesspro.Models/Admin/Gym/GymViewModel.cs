using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitnesspro.Models.Admin.Gym
{
    public class GymViewModel
    {
        public int GymId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GymName { get; set; }
        public long MobileNumber { get; set; }
        public long TelephoneNumber { get; set; }
        public DateTime EnrolledDate { get; set; }
        public string Email { get; set; }
        public int EstablishedYear { get; set; }
        public int ServiceId { get; set; }
    }
}
