using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.IO;
namespace AgroChemical
{
    
    static class AgroFUN
    {
        public static string gblConnString { get; set; }
        public static int gblLogID { get; set; }
        public static int gblUserID { get; set; }
        public static string getConnectionString()
        {
            string strConn=string.Empty;
            RegistryKey localKey = RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey rKey = localKey.OpenSubKey("Software\\WinAgro\\KeyLocal", false);           
            
            try
            {
                string sname = (string)rKey.GetValue("sname");          
                string fbpateh = (string)rKey.GetValue("swhere");
                strConn = "User=SYSDBA;Password=masterkey;Database=" + fbpateh.ToString() + ";DataSource=" + sname.ToString() + ";Dialect=3; Charset=NONE;Role=;Connection lifetime=5;Pooling=true; MinPoolSize=0;MaxPoolSize=50;Packet Size=8192;ServerType=0";
                gblConnString = strConn;                
            }
            catch (Exception mess)
            {
               
                SystemLog("Connection: "+mess.Message.ToString());
            }
            return strConn;
        }
        public static string EncodePassword(string sData)
        {
            try
            {
                byte[] encData_byte = new byte[sData.Length];

                encData_byte = System.Text.Encoding.UTF8.GetBytes(sData);

                string encodedData = Convert.ToBase64String(encData_byte);

                return encodedData;

            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }
        public static string DecodePassword(string sData)
        {

            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();

            System.Text.Decoder utf8Decode = encoder.GetDecoder();

            byte[] todecode_byte = Convert.FromBase64String(sData);

            int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);

            char[] decoded_char = new char[charCount];

            utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);

            string result = new String(decoded_char);

            return result;

        }
      
        public static void SystemLog(string content)
        {
            if (!Directory.Exists(@"C:\AgroLog\"))
            {
                Directory.CreateDirectory(@"C:\AgroLog\");
            }
            string sPath = @"C:\AgroLog\DataPos.txt";
            FileInfo info = new FileInfo(sPath);;
            TimeSpan days = new TimeSpan(30, 0, 0, 0);
            if (info.CreationTime <= DateTime.Now.Subtract(days))
            {
                if (info.Exists)
                {
                    info.Delete();
                    FileStream fs = new FileStream(sPath, FileMode.Create, FileAccess.Write);
                    fs.Close();
                    info.CreationTime = DateTime.Now;
                }

            }

            TextWriter txtWr = new StreamWriter(sPath, true);
            txtWr.WriteLine(DateTime.Now.ToString() + "   " + content);
            txtWr.Close();
        }
        
    }
}
