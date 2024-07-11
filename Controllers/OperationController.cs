using CoreAPI_Tracking.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using CoreAPI_Tracking.AppCode;

namespace CoreAPI_Tracking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationController : ControllerBase
    {


        public readonly IConfiguration _configuration;

        public OperationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("GETRFC")]
        public RFCResponse GETRFC()
        {
            RFCResponse objRFC = new RFCResponse();
            try
            {
                DA objDA = new DA(_configuration);
                objRFC = objDA.GetRFC();
            }
            catch (Exception ex)
            {
                objRFC.status = false;
                objRFC.Message= ex.Message.ToString(); 
            }
            return objRFC;
        }
    }

}
