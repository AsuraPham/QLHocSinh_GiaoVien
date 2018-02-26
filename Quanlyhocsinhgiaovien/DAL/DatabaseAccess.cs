using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
   public class DatabaseAccess
    {
       string strConn = "Data Source=.\\SQLEXPRESS;Initial Catalog=QuanLyHocSinhGV;Integrated Security=True";
       public  SqlConnection conn = null;
       public void OpenConnection()
       {
           if (conn == null)
               conn = new SqlConnection(strConn);
           if (conn.State == ConnectionState.Closed)
               conn.Open();
       }
       public void CloseConnection()
       {
           if (conn != null && conn.State == ConnectionState.Open)
               conn.Close();
       }
       private static DatabaseAccess instance;  //Ctrl R+E  //đóng gói

        public static DatabaseAccess Instance
        {
            get { if(instance==null) instance=new DatabaseAccess();return DatabaseAccess.instance; }
           private set { DatabaseAccess.instance = value; }
        }
      protected DatabaseAccess(){}
      private string connectionSTR="Data Source=.\\SQLEXPRESS;Initial Catalog=QuanlyHocSinhGV;Integrated Security=True";
      public DataTable ExcuteQuery(string query,object[] pramater =null)
      {
          DataTable data = new DataTable();
          using (SqlConnection connection = new SqlConnection(connectionSTR))
          {
              connection.Open();
              SqlCommand command = new SqlCommand(query, connection);

              if(pramater!=null)
              {
                  string[] listPars = query.Split(' ');
                  int i = 0;
                  foreach(string item in listPars)
                  {
                      if(item.Contains('@'))
                      {
                          command.Parameters.AddWithValue(item, pramater[i]);
                              i++;
                      }                
                  }
              }
              SqlDataAdapter adapter = new SqlDataAdapter(command);
              adapter.Fill(data);

              connection.Close();
          }
          return data;
      }
      public int ExcuteNonQuery(string query, object[] pramater = null)
      {
          int data = 0;
          using (SqlConnection connection = new SqlConnection(connectionSTR))
          {
              connection.Open();
              SqlCommand command = new SqlCommand(query, connection);

              if (pramater != null)
              {
                  string[] listPars = query.Split(' ');
                  int i = 0;
                  foreach (string item in listPars)
                  {
                      if (item.Contains('@'))
                      {
                          command.Parameters.AddWithValue(item, pramater[i]);
                          i++;
                      }
                  }
              }
              data = command.ExecuteNonQuery();
              connection.Close();
          }
          return data;
      }
      public object ExcuteScalar(string query, object[] pramater = null)
      {
          object data = 0;
          using (SqlConnection connection = new SqlConnection(connectionSTR))
          {
              connection.Open();
              SqlCommand command = new SqlCommand(query, connection);

              if (pramater != null)
              {
                  string[] listPars = query.Split(' ');
                  int i = 0;
                  foreach (string item in listPars)
                  {
                      if (item.Contains('@'))
                      {
                          command.Parameters.AddWithValue(item, pramater[i]);
                          i++;
                      }
                  }
              }
              data = command.ExecuteScalar();
              connection.Close();
          }
          return data;
      }

    }
}
