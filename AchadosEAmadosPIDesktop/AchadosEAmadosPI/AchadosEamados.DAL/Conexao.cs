using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AchadosEamados.DAL
{
    public class Conexao
    {
        protected SqlConnection conexao;
        protected SqlCommand command;
        protected SqlDataReader dataReader;

        protected void Conectar()
        {
            try
            {
                conexao = new SqlConnection(@"Server=tcp:achadosdb.database.windows.net,1433;Initial Catalog=achadosdb;Persist Security Info=False;User ID=adminachados;Password=amados@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                conexao.Open();


            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
        protected void Desconectar()
        {
            try
            {
                conexao.Close();
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
        }
    }
}
