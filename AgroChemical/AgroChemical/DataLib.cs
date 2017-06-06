using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FireBird.SQLHelper;
using FirebirdSql.Data.FirebirdClient;
using System.Data;

namespace AgroChemical
{
    class DataLib
    {
        public DataSet ExecuteDataset(string Conn, string Squery)
        {
            DataSet ds = new DataSet();
            try
            {               
                ds = SqlHelper.ExecuteDataset(Conn, CommandType.Text, Squery);

                return ds;
            }
            catch (Exception)
            {
                return ds;
            }
        }
        public DataTable ExecuteDatTable(string Conn, string Squery)
        {
            DataTable dt = new DataTable();
            try
            {
                DataSet ds = new DataSet();               
                ds = SqlHelper.ExecuteDataset(Conn, CommandType.Text, Squery);
                if(ds.Tables.Count > 0 )
                    dt = ds.Tables[0];
                
                return dt;
            }
            catch (Exception e)
            {
                AgroFUN.SystemLog("DataTable" + e.Message.ToString());
                return dt;
            }

        }
        public int ReturnID(string Conn, string Squery, string vfield)
        {
            int iID = 0;
            try
            {
                
                DataSet ds = new DataSet();
                FbParameter[] objParams = new FbParameter[1];
                objParams[0] = new FbParameter(vfield, SqlDbType.Int);
                objParams[0].Direction = ParameterDirection.Output;

                SqlHelper.ExecuteNonQuery(Conn, CommandType.Text, Squery, objParams);
                iID = (int)(objParams[0].Value);
                return iID;
            }
            catch (Exception e)
            {
                AgroFUN.SystemLog("ReturnID" + e.Message.ToString());
                return iID;
            }
        }
        public  void StoreProcedure(string Conn,string cmdStr, string sParammeter)
        {
           
            FbParameter[] objParams1 = new FbParameter[1];
            objParams1 = SqlHelperParameterCache.GetSpParameterSet(Conn, cmdStr, true);
            objParams1[0].Value = sParammeter;
            //int ret = 0;   
            //ret=SqlHelper.ExecuteNonQuery(serverconn,cmdStr,objParams1);
            DataSet obj6;
            obj6 = SqlHelper.ExecuteDataset(Conn, CommandType.StoredProcedure, cmdStr, objParams1);
        }
        public  Boolean CheckRecordExist(string Conn, string Squery)
        {
           
            DataTable custDS = new DataTable();
            try
            {
                DataSet ds = new DataSet();
                ds = SqlHelper.ExecuteDataset(Conn, CommandType.Text, Squery);

                custDS = ds.Tables[0];
                if (custDS.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            finally
            {                
                custDS.Dispose();                
            }
        }

        public void ExecuteNonQuery(string Conn, string Squery)
        {
            try
            {
                
                SqlHelper.ExecuteNonQuery(Conn, CommandType.Text, Squery);
            }
            catch (Exception)
            {              
            }
        }
        public void UpdateImage(string Conn,DataRow drImage)
        {
            // MemoryStream msData = null;
            byte[] content = (byte[])drImage["ITEMIMAGE"];
            //MemoryStream msData = new MemoryStream(content);
            // posDlib.ExecuteNonQuery(strLoc, "UPDATE MST_ITEM Set itemimage='" + content + "' where iitemid='" + drImage["IITEMID"] + "'");
           /* FbConnection conn = new FbConnection();
            conn.ConnectionString = strLoc;
            conn.Open();
            FbCommand cmd = new FbCommand("MST_UPDATEIMAGE", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IIMAGEID", FbDbType.Integer).Value = drImage["IITEMID"];

            cmd.Parameters.Add("@IMG", FbDbType.Binary).Value = content;
            cmd.ExecuteNonQuery();
            conn.Close();*/

            FbParameter[] objParams1 = new FbParameter[2];
            objParams1 = SqlHelperParameterCache.GetSpParameterSet(Conn, "MST_UPDATEIMAGE", true);
            objParams1[0].Value = drImage["IITEMID"];
            objParams1[1].Value = content;
            //int ret = 0;   
            SqlHelper.ExecuteNonQuery(Conn, "MST_UPDATEIMAGE", objParams1);
           
           // SqlHelper.ExecuteDataset(Conn, CommandType.StoredProcedure, "MST_UPDATEIMAGE", objParams1);

        }
        public  void LOGDETAIL(string vAction)
        {
            string sqlInsert;

            try
            {

                if (AgroFUN.gblLogID == 0)
                {
                    sqlInsert = "INSERT INTO USERLOG(UserID,LogDate) values " +
                        "(" + AgroFUN.gblUserID + ",'" + DateTime.Now.ToString("MM-dd-yyyy") + "')" +
                        " returning ID";
                    // MessageBox.Show(sqlInsert);                   
                    AgroFUN.gblLogID = ReturnID(AgroFUN.gblConnString, sqlInsert, "ID");
                    
                   
                }
                sqlInsert = "INSERT INTO USERLOGDETAIL(LOGID,TASK,LOGDATETIME)" +
                    " values ('" + AgroFUN.gblLogID + "','" + vAction + "','" + DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss") + "')";
                ExecuteNonQuery(AgroFUN.gblConnString, sqlInsert);
                //Here Insert for local database recover opening balance               
            }
            catch (Exception e)
            {
                AgroFUN.SystemLog("Log ERRorr"+e.Message.ToString());

            }
        }
    }
}
