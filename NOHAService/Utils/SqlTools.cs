using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NOHAService.Utils
{
  public class SqlTools
  {

    public static string SQLExecute(string sQuery)
    {
      var cadCnx = System.Configuration.ConfigurationManager.ConnectionStrings["NOHA_ADO"].ToString();

      #region old_code
      using (var sqlConnection = new SqlConnection(cadCnx))
      {
        sqlConnection.Open();
        var dbCmd = new System.Data.SqlClient.SqlCommand(sQuery, sqlConnection);
        try
        {
          dbCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
          Exception customException = new Exception();
          //if (ExceptionPolicy.HandleException(ex, "Business Layer Policy", customException))
          //{
          //    throw customException;
          //}
        }
        finally
        {
          sqlConnection.Close();
        }
      }
      #endregion

      return "";
    }

    public static DataTable AdoSqlGetDataTable(string sQuery, string alternativeCnx = "")
    {

      {
        SqlConnection sqlConnection;
        if (string.IsNullOrEmpty(alternativeCnx))
        {
          sqlConnection =
            new SqlConnection(
              System.Configuration.ConfigurationManager.ConnectionStrings["NOHA_ADO"].ToString());
        }
        else
        {
          sqlConnection =
            new SqlConnection(
              System.Configuration.ConfigurationManager.ConnectionStrings[alternativeCnx].ToString());
        }
        sQuery = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + sQuery;
        var DsResult = new DataSet();
        var Result = new DataTable();



        sqlConnection.Open();

        try
        {
          using (SqlDataAdapter dbAdapter = new SqlDataAdapter(sQuery, sqlConnection))
          {
            dbAdapter.Fill(DsResult, "Table");
            if (DsResult.Tables.Count > 0)
            {
              Result = DsResult.Tables[0];
            }
          }
        }
        catch (Exception ex)
        {
          //Exception customException = new Exception();
          //if (ExceptionPolicy.HandleException(ex, "Business Layer Policy", customException))
          //{
          //    throw customException;
          //}
          //MessageBox.Show(ex.Message);
        }
        finally
        {
          DsResult.Dispose();
          sqlConnection.Close();
          //dbCxn.Close();
        }

        return Result;
      }
    }

    public static IEnumerable<T> ExecSqlGetList<T>(string query, string alternativeCnx = "") where T : new()
    {
      //var cadCnx = System.Configuration.ConfigurationManager.ConnectionStrings["Terpel_TC_ProdADO"].ToString();
      //var empList = new List<T>();
      //query = "SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED;" + query;
      //using (var _db = new SqlConnection(cadCnx))
      //{
      //    empList = _db.Query<T>(query).ToList();
      //}

      //return empList;

      var obj = AdoSqlGetDataTable(query, alternativeCnx);
      var res = obj.ToList<T>();
      return res;


    }
  }

  public static class DataTableExtensions
  {



    private static Dictionary<Type, IList<PropertyInfo>> typeDictionary = new Dictionary<Type, IList<PropertyInfo>>();
    public static IList<PropertyInfo> GetPropertiesForType<T>()
    {
      var type = typeof(T);
      if (!typeDictionary.ContainsKey(typeof(T)))
      {
        typeDictionary.Add(type, type.GetProperties().ToList());
      }
      return typeDictionary[type];
    }

    //public static IList<T> ToList<T>(this DataTable table) where T : new()
    //{
    //  IList<PropertyInfo> properties = GetPropertiesForType<T>();
    //  IList<T> result = new List<T>();

    //  foreach (var row in table.Rows)
    //  {
    //    var item = CreateItemFromRow<T>((DataRow)row, properties);
    //    result.Add(item);
    //  }

    //  return result;
    //}

    private static T CreateItemFromRow<T>(DataRow row, IList<PropertyInfo> properties) where T : new()
    {
      T item = new T();
      foreach (var property in properties)
      {
        property.SetValue(item, row[property.Name], null);
      }
      return item;
    }


    public static IList<T> ToList<T>(this DataTable table) where T : new()
    {

      string propName = string.Empty;
      List<T> entityList = new List<T>();

      foreach (DataRow dr in table.Rows)
      {
        // Create Instance of the Type T
        T entity = System.Activator.CreateInstance<T>();

        // Get all properties of the Type T
        System.Reflection.PropertyInfo[]
        entityProperties = typeof(T).GetProperties();

        // Loop through the properties defined in the 
        // entityList entity object and mapped the value
        foreach (System.Reflection.PropertyInfo item in
                entityProperties)
        {
          propName = string.Empty;
          if (propName.Equals(string.Empty))
            propName = item.Name;

          if (table.Columns.Contains(propName))
          {
            // Assign value to the property
            try
            {
              item.SetValue
              (
                  entity,
                  dr[propName].GetType().
                      Name.Equals(typeof(DBNull).Name)
                      ? null : dr[propName],
                  null
              );
            }
            catch (Exception)
            {

              throw;
            }

          }
        }


        entityList.Add(entity);
      }
      return entityList;
    }

  }
}
