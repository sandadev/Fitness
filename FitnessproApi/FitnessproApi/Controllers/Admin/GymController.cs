using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using FitnessproApi.Models.Db_Config;
using FitnessproApi.Models.ViewModels;

namespace FitnessproApi.Controllers.Admin
{
    [RoutePrefix("api/Admin")]
    public class GymController : ApiController
    {
        //get gym list
        [HttpGet]
        [Route("GymList")]
        public IEnumerable<Gym> GymList()
        {
            using (var ctx = new FitnessproEntities()) {
                List<Gym> gymList = ctx.Gyms.ToList();
                return gymList;
            }
        }

        //add new gym
        [HttpPost]
        [Route("CreateGym")]
        public HttpStatusCode AddGym([FromBody] Gym gymDetails)
        {
            try
            {
                using (var ctx = new FitnessproEntities())
                {
                    ctx.Gyms.Add(gymDetails);
                    ctx.SaveChanges();
                    return HttpStatusCode.Created;
                }
            }
            catch (Exception ex)
            {
                return HttpStatusCode.BadRequest;
            }

        }
        //update gym
        [HttpPut]
        [Route("UpdateGym")]
        public HttpStatusCode EditGym([FromUri] int id,[FromBody] Gym gymDetails)
        {
            try
            {
                using (var ctx = new FitnessproEntities()) {
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
                    return HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
               return HttpStatusCode.BadRequest;
                
            }

        }
        //delete gym
        [HttpDelete]
        public HttpStatusCode DeleteGym([FromUri] int id)
        {
            using (var ctx = new FitnessproEntities())
            {
                Gym gymdetails = ctx.Gyms.Find(id);
                ctx.Gyms.Remove(gymdetails);
                return HttpStatusCode.OK;
            }
        }

    }
}
