using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BancoDados
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public string Nome { get; set; }
        public string Usr { get; set; }
        public string Email{ get; set; }
        public string Senha { get; set;}
       

        public Usuario()
        {
            UsuarioId = 0;
            Nome = string.Empty;
            Usr = string.Empty;
            Email = string.Empty;
            Senha = string.Empty;
          
        }

    }
}
