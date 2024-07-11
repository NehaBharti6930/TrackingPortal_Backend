using CoreAPI_Tracking.AppCode;
using CoreAPI_Tracking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreAPI_Tracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterController : ControllerBase
    {
        public readonly IConfiguration _configuration;

        public MasterController(IConfiguration configuration)
        {
            _configuration = configuration;
        }





        [HttpGet]
        [Route("GETCHANGETYPE")]
        public List<ChangeTypeResponse> GETCHANGETYPE()
        {
            List<ChangeTypeResponse> lstChangeType = new List<ChangeTypeResponse>();
            try
            {
                DA objDA = new DA(_configuration);
                lstChangeType = objDA.GetChangeType();
            }
            catch (Exception ex)
            {
                lstChangeType = null;
            }
            return lstChangeType;
        }


        [HttpGet]
        [Route("GETCONCERNEDAPPLICATION")]

        public List<ConcernedApplicationResponse> GETCONCERNEDAPPLICATION()
        {
            List<ConcernedApplicationResponse> lstConsernedApplication = new List<ConcernedApplicationResponse>();
            try
            {
                DA objDA = new DA(_configuration);
                lstConsernedApplication = objDA.GetConcernedApplication();
            }
            catch (Exception ex)
            {
                lstConsernedApplication = null;
            }
            return lstConsernedApplication;
        }

            [HttpGet]
            [Route("GETPLANTAFFECTED")]


             public List<PlantAffectedResponse> GETPLANTAFFECTED()
             {
            List<PlantAffectedResponse> lstplantAffected = new List<PlantAffectedResponse>();
            try
            {
                DA objDA = new DA(_configuration);
                lstplantAffected = objDA.GetPlantAffected();
            }
            catch (Exception ex)
            {
                lstplantAffected = null;
            }
               return lstplantAffected;
             }


            [HttpGet]
            [Route("GETPROCESSINVOLVED")]
            public List<ProcessInvolvedResponse> GETPROCESSINVOLVED()
             {
            List<ProcessInvolvedResponse> lstProcessInvolved= new List<ProcessInvolvedResponse>();
            try
            {
                DA objDA = new DA(_configuration);
                lstProcessInvolved = objDA.GetProcessInvolved();
            }
            catch (Exception ex)
            {
                lstProcessInvolved = null;
               }
              return lstProcessInvolved;
             }

                [HttpGet]
                [Route("GETAPPROVELNEEDS")]


                  public List<ApprovelNeedsResponse> GETAPPROVELNEEDS()
                {
            List<ApprovelNeedsResponse> lstApprovelNeeds = new List<ApprovelNeedsResponse>();
                try
                {
                   DA objDA = new DA(_configuration);
                lstApprovelNeeds = objDA.GetApprovelNeeds();
                }
                catch (Exception ex)
                {
                lstApprovelNeeds = null;
                }
                    return lstApprovelNeeds;
                  }


                //[HttpGet]
                //[Route("GETSTATUS")]


                // public RFCResponse GETRFC()
                //{
                //  RFCResponse objRFC = new RFCResponse();
                //try
                //{
                //    DA objDA = new DA(_configuration);
                //    objRFC = objDA.GetRFC();
                //}
                //catch (Exception ex)
                //{
                //    objRFC.status = false;
                //    objRFC.Message = ex.Message.ToString();
                //}
                //    return objRFC;
                //  }





        }
    }

