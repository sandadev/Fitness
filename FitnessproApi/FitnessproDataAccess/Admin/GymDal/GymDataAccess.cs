using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessproDataAccess.Model;
using Fitnesspro.Models.Admin.Gym;

namespace FitnessproDataAccess.Admin.GymDal
{
   public class GymDataAccess
    {
            

        public IEnumerable<GymViewModel> GymList()
        {
            using (var ctx = new FitnessproEntities())
            {
                List<GymViewModel> gymList = (from g in ctx.Gyms
                                                       select new GymViewModel
                                                       {
                                                           GymId = g.GymId,
                                                           GymName=g.GymName,
                                                           FirstName=g.FirstName,
                                                           LastName=g.LastName,
                                                           MobileNumber=(long)g.MobileNumber,
                                                           TelephoneNumber=(long)g.TelephoneNumber,
                                                           EnrolledDate=(DateTime)g.EnrolledDate,
                                                           Email=g.Email,
                                                           EstablishedYear=(int)g.EstablishedYear,
                                                           ServiceId=(int)g.ServiceId
                                                       }).ToList();
                return gymList;
            }
        }

        public bool CreateGym(Gym gymDetails)
        {
            bool isSuccess = false;
            try
            {
                using (var ctx = new FitnessproEntities())
                {
                    ctx.Gyms.Add(gymDetails);
                    ctx.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception)
            {
                isSuccess = false;
                throw;
            }
            return isSuccess;
        }

        public bool UpdateGym(int id,Gym gymDetails)
        {
            bool isSuccess = false;
            try
            {
                using (var ctx = new FitnessproEntities())
                {
                    Gym gymdetails = ctx.Gyms.Where(x => x.GymId == id).SingleOrDefault();
                    gymdetails.FirstName = gymDetails.FirstName;
                    gymdetails.LastName = gymDetails.LastName;
                    gymdetails.GymName = gymDetails.GymName;
                    gymdetails.MobileNumber = gymDetails.MobileNumber;
                    gymdetails.TelephoneNumber = gymDetails.TelephoneNumber;
                    gymdetails.EnrolledDate = gymDetails.EnrolledDate;
                    gymdetails.Email = gymDetails.Email;
                    gymdetails.EstablishedYear = gymDetails.EstablishedYear;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {
                isSuccess = false;
                throw;
            }
            return isSuccess;
        }


    }
}
