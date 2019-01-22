using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilador
{
    public class Token
    {
        public string id, tipo;
        public Token proximoToken;
        public Token()
        {
            id = "ID";
            tipo = "TIPO";
            proximoToken = null;
        }
        public Token(string id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
            this.proximoToken = null;
        }
    }
}
