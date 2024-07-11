using CoreAPI_Tracking.Models;
using System.Data;
using System.Data.SqlClient;


namespace CoreAPI_Tracking.AppCode
{
    public class DA
    {
        public readonly IConfiguration _configuration;
        public DA(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public RFCResponse GetRFC()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            RFCResponse objRFC = new RFCResponse();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetRFC", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    objRFC.status = true;
                    objRFC.Message = "Success";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        RFCResponseNew objRFCResponse = new RFCResponseNew();
                        objRFCResponse.PLANT_CODE = dt.Rows[i]["PLANT_CODE"].ToString();
                        objRFCResponse.APPLICATION_OTHER_DESC = dt.Rows[i]["APPLICATION_OTHER_DESC"].ToString();
                        objRFC.lstRFC.Add(objRFCResponse);
                    }
                }
                else
                {
                    objRFC.status = false;
                    objRFC.Message = "Failed";
                    objRFC.lstRFC = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return objRFC;            

        }

        public List<ChangeTypeResponse> GetChangeType()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            List<ChangeTypeResponse> lstChangeType=new List<ChangeTypeResponse>();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetChangeType", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ChangeTypeResponse objChangeType = new ChangeTypeResponse();
                        objChangeType.CHANGETYPEID = Convert.ToInt64(dt.Rows[i]["CHANGETYPEID"]);
                        objChangeType.CHANGETYPENAME = dt.Rows[i]["CHANGETYPENAME"].ToString();
                        objChangeType.CREATEDBY = dt.Rows[i]["CREATEDBY"].ToString();
                        lstChangeType.Add(objChangeType);
                    }
                }
                else
                {
                    lstChangeType = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lstChangeType;

        }



        public List<ConcernedApplicationResponse> GetConcernedApplication()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            List<ConcernedApplicationResponse> lstConcernedApplication = new List<ConcernedApplicationResponse>();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetConcernedApplication", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ConcernedApplicationResponse objConcernedApplication = new ConcernedApplicationResponse();
                        objConcernedApplication.CONCERNED_APPLICATION_ID = Convert.ToInt64(dt.Rows[i]["CONCERNED_APPLICATION_ID"]);
                        objConcernedApplication.APPLICATION_NAME = dt.Rows[i]["APPLICATION_NAME"].ToString();
                      //  objConcernedApplication.ISACTIVE = Convert.ToBoolean(dt.Rows[i]["ISACTIVE"]);
                        objConcernedApplication.CREATEDBY = dt.Rows[i]["CREATEDBY"].ToString();
                       // objConcernedApplication.CREATEDON = Convert.ToDatetime(dt.Rows[i]["CREATEDON"]);
                        objConcernedApplication.UPDATEDBY = dt.Rows[i]["UPDATEBY"].ToString();
                        // objConcernedApplication.UPDATEDON = Convert.To dt.Rows[i]["UPDATEON"].ToString();


                        lstConcernedApplication.Add(objConcernedApplication);
                    }
                }
                else
                {
                    lstConcernedApplication = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lstConcernedApplication;

        }


        public List<PlantAffectedResponse> GetPlantAffected()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            List<PlantAffectedResponse> lstplantAffected =new List<PlantAffectedResponse>();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetPlantAffected", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        PlantAffectedResponse objPlantAffected = new PlantAffectedResponse();
                        objPlantAffected.PLANT_ID = Convert.ToInt64(dt.Rows[i]["PLANT_ID"]);
                        objPlantAffected.PLANT_CODE = Convert.ToInt64(dt.Rows[i]["PLANT_CODE"]);
                        objPlantAffected.PLANTNAME = dt.Rows[i]["PLANTNAME"].ToString();
                       // objPlantAffected.DISPLAYORDER = Convert.ToInt64(dt.Rows[i]["DISPLAYORDER"]);
                        objPlantAffected.ISACTIVE = Convert.ToBoolean(dt.Rows[i]["ISACTIVE"]);
                        objPlantAffected.CREATEDBY = dt.Rows[i]["CREATEDBY"].ToString();
                        // objPlantAffected.CREATEDON = dt.Rows[i]["CREATEDON"].ToString();
                        objPlantAffected.UPDATEDBY = dt.Rows[i]["UPDATEDBY"].ToString();
                        //objPlantAffected.UPDATEDON = dt.Rows[i]["UPDATEDON"].ToString();



                        lstplantAffected.Add(objPlantAffected);
                    }
                }
                else
                {
                    lstplantAffected = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lstplantAffected;

        }


        public List<ProcessInvolvedResponse> GetProcessInvolved()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            List<ProcessInvolvedResponse> lstProcessInvolved = new List<ProcessInvolvedResponse>();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetProcessInvolved", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ProcessInvolvedResponse objProcessInvolved= new ProcessInvolvedResponse();
                        objProcessInvolved.PROCESSINVOLVED_ID = Convert.ToInt64(dt.Rows[i]["PROCESSINVOLVED_ID"]);
                        objProcessInvolved.PROCESSINVOLVEDNAME = dt.Rows[i]["PROCESSINVOLVEDNAME"].ToString();
                        objProcessInvolved.DISPLAYORDER = Convert.ToInt64(dt.Rows[i]["DISPLAYORDER"]);
                        objProcessInvolved.ISACTIVE = Convert.ToBoolean(dt.Rows[i]["ISACTIVE"]);
                        objProcessInvolved.CREATEDBY = dt.Rows[i]["CREATEDBY"].ToString();
                       // objProcessInvolved.CREATEDON = dt.Rows[i]["CREATEDON"].ToString();
                        objProcessInvolved.UPDATEDBY = dt.Rows[i]["UPDATEDBY"].ToString();
                        //  objProcessInvolved.UPDATEDON = dt.Rows[i]["UPDATEDON"].ToString();
                        lstProcessInvolved.Add(objProcessInvolved);
                    }
                }
                else
                {
                    lstProcessInvolved = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lstProcessInvolved;

        }


        public List<ApprovelNeedsResponse> GetApprovelNeeds()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            List<ApprovelNeedsResponse> lstApprovelNeeds= new List<ApprovelNeedsResponse>();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetApprovelNeeds", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                   
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ApprovelNeedsResponse objApprovelNeeds = new ApprovelNeedsResponse();
                        objApprovelNeeds.APPROVER_ID = Convert.ToInt64(dt.Rows[i]["APPROVER_ID"]);
                        objApprovelNeeds.APPROVER_NAME = dt.Rows[i]["APPROVER_NAME"].ToString();
                        objApprovelNeeds.APPROVER_DESIGNATION = dt.Rows[i]["APPROVER_DESIGNATION"].ToString();
                        objApprovelNeeds.STATUS = Convert.ToChar(dt.Rows[i]["STATUS"]);
                        objApprovelNeeds.ISACTIVE = Convert.ToBoolean(dt.Rows[i]["ISACTIVE"]);
                        objApprovelNeeds.REVIEWBY = dt.Rows[i]["REVIEWBY"].ToString();
                       // objApprovelNeeds.REVIEWON = dt.Rows[i]["REVIEWON"].ToString();
                        objApprovelNeeds.UPDATEDBY = dt.Rows[i]["UPDATEDBY"].ToString();
                        //  objApprovelNeeds.UPDATEDON = dt.Rows[i]["UPDATEDON"].ToString();
                        lstApprovelNeeds.Add(objApprovelNeeds);
                    }
                }
                else
                {
                    lstApprovelNeeds = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lstApprovelNeeds;

        }


        public RFCResponse GetStatus()
        {
            SqlConnection con = new SqlConnection(_configuration.GetConnectionString("Conn").ToString());
            RFCResponse objRFC = new RFCResponse();
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("USP_GetStatus", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    objRFC.status = true;
                    objRFC.Message = "Success";
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        RFCResponseNew objRFCResponse = new RFCResponseNew();
                        objRFCResponse.PLANT_CODE = dt.Rows[i]["PLANT_CODE"].ToString();
                        objRFCResponse.APPLICATION_OTHER_DESC = dt.Rows[i]["APPLICATION_OTHER_DESC"].ToString();
                        objRFC.lstRFC.Add(objRFCResponse);
                    }
                }
                else
                {
                    objRFC.status = false;
                    objRFC.Message = "Failed";
                    objRFC.lstRFC = null;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return objRFC;

        }


    }
}
