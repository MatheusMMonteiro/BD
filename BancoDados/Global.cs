using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BancoDados
{
    public static class Global
    {
        public static string Servidor = string.Empty;
        public static string Banco = string.Empty;
        public static string StringConexao = string.Empty;

        public static void LerAppConfig()
        {
            try
            {
                Servidor = ConfigurationManager.AppSettings["Servidor"];
                Banco = ConfigurationManager.AppSettings["Banco"];

                StringConexao = string.Format("Data Source={0};Initial Catalog={1};" +
                    "Integrated Security=true;", Servidor, Banco);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
