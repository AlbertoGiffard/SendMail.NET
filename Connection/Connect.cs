using Entity;
using System;
using System.Data.SqlClient;
using System.Text;

namespace Connection
{
    public static class Connect
    {
        private static string connectionStr;
        /// <summary>
        /// Siempre inicializo con la misma base cada vez que se ejecuta el disparador
        /// </summary>
        static Connect()
        {
            connectionStr = @"Data Source = .; Initial Catalog = PDC_Emblue; Integrated Security = True";
        }
        /// <summary>
        /// La consulta se le pasa por parametro y el resto estaria parametrizado
        /// </summary>
        /// <param name="query"></param>
        /// <returns> true si no hubo problema </returns>
        public static bool ExecuteQuery(string query)
        {
            bool result = false;

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                command.ExecuteNonQuery();//INSERT - UPDATE - DELETE

                result = true;
            }

            return result;
        }
        /// <summary>
        /// Obtiene los datos de las campañas que cumplen con la query
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns>Devuelve el listado de las campañas en el modelo id;subject;date</returns>
        public static string GetCampaignsFromTo(DateTime from, DateTime to)
        {
            StringBuilder sb = new StringBuilder();

            string query = $"SELECT * FROM Campaign WHERE Campaign.Date BETWEEN CONVERT(date, '{from}', 103) AND CONVERT(date, '{to}',103)";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    FileAttach fileAttacher = new FileAttach((Convert.ToInt32(dataReader["Id"])), dataReader["NameFile"].ToString(), dataReader["FilePath"].ToString());

                    Campaign campaign = new Campaign((Convert.ToInt32(dataReader["Id"])), dataReader["Subject"].ToString(), null, null, Convert.ToDateTime(dataReader["Date"]), fileAttacher);

                    sb.AppendLine(campaign.ToString());
                }

                dataReader.Close();
            }

            if (sb.ToString() == "")
            {
                sb.AppendLine("Sin registros en ese período de tiempo");
            }

            return sb.ToString();
        }
        /// <summary>
        /// Trae las campañas que cuenten con informacion en los campos de archivos adjuntos
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns>Un string con todos las campañas que encontró</returns>
        public static string GetCampaignsAttachFromTo(DateTime from, DateTime to)
        {
            StringBuilder sb = new StringBuilder();

            string query = $"SELECT * FROM Campaign WHERE Campaign.Date BETWEEN CONVERT(date, '{from}', 103) AND CONVERT(date, '{to}',103) and Campaign.NameFile IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    FileAttach fileAttacher = new FileAttach((Convert.ToInt32(dataReader["Id"])), dataReader["NameFile"].ToString(), dataReader["FilePath"].ToString());

                    Campaign campaign = new Campaign((Convert.ToInt32(dataReader["Id"])), dataReader["Subject"].ToString(), null, null, Convert.ToDateTime(dataReader["Date"]), fileAttacher);

                    sb.AppendLine(campaign.ToString());
                }

                dataReader.Close();
            }

            if (sb.ToString() == String.Empty)
            {
                sb.AppendLine("Sin registros en ese período de tiempo");
            }

            return sb.ToString();
        }
        /// <summary>
        /// trae la campaña por ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Campaign GetCampaign(int id)
        {
            Campaign campaign1 = null;

            string query = $"SELECT * FROM Campaign WHERE Campaign.Id = '{id}'";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    FileAttach fileAttacher = new FileAttach((Convert.ToInt32(dataReader["Id"])), dataReader["NameFile"].ToString(), dataReader["FilePath"].ToString());

                    campaign1 = new Campaign((Convert.ToInt32(dataReader["Id"])), dataReader["Subject"].ToString(), null, null, Convert.ToDateTime(dataReader["Date"]), fileAttacher);
                }

                dataReader.Close();
            }

            return campaign1;
        }
        /// <summary>
        /// Trae la campaña por Id si posee datos en las columnas de adjuntos
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static Campaign GetCampaignWithAttach(int id)
        {
            Campaign campaign1 = null;

            string query = $"SELECT * FROM Campaign WHERE Campaign.Id = '{id}' and Campaign.NameFile IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    FileAttach fileAttacher = new FileAttach((Convert.ToInt32(dataReader["Id"])), dataReader["NameFile"].ToString(), dataReader["FilePath"].ToString());

                    campaign1 = new Campaign((Convert.ToInt32(dataReader["Id"])), dataReader["Subject"].ToString(), null, null, Convert.ToDateTime(dataReader["Date"]), fileAttacher);
                }

                dataReader.Close();
            }

            return campaign1;
        }
    }
}
