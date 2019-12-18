using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using Fitnesspro.Models.Admin.Gym;
using FitnessproDataAccess.Admin.GymDal;
using FitnessproDataAccess.Model;

namespace FitnessproApi.Controllers.Admin
{
    [RoutePrefix("api/Admin")]
    public class GymController : ApiController
    {
        GymDataAccess ctxGym;
        public GymController()
        {
            ctxGym = new GymDataAccess(); 
        }
        //        get gym list
        [HttpGet]
        [Route("GymList")]
        public IEnumerable<GymViewModel> GymList()
        {
            try
            {
                return ctxGym.GymList();
            }
            catch (Exception)
            {
                throw;
            }
        }



       // add new gym
        [HttpPost]
        [Route("CreateGym")]
        public HttpStatusCode AddGym([FromBody] Gym gymDetails)
        {
            try
            {
                if (ctxGym.CreateGym(gymDetails)) ;
                {
                    return HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                return HttpStatusCode.BadRequest;
            }

        }

        ////update gym
        //[HttpPut]
        //[Route("UpdateGym")]
        //public HttpStatusCode EditGym([FromUri] int id, [FromBody] Gym gymDetails)
        //{
        //    try
        //    {
              
        //    }
        //    catch (Exception ex)
        //    {
        //        return HttpStatusCode.BadRequest;

        //    }

            //}
            ////delete gym
            //[HttpDelete]
            //public HttpStatusCode DeleteGym([FromUri] int id)
            //{
            //    using (var ctx = new FitnessproEntities())
            //    {
            //        Gym gymdetails = ctx.Gyms.Find(id);
            //        ctx.Gyms.Remove(gymdetails);
            //        return HttpStatusCode.OK;
            //    }
            //}

        }
}
