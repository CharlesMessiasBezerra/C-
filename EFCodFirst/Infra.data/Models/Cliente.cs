using System;
using System.Collections.Generic;

namespace Infra.data.Models
{
    public class Cliente
    {
        public int pk_intCod { get; set; }
        public int? fk_intBairro { get; set; }
        public string strNOME { get; set; }
        public int? intIdade { get; set; }
        public string strSexo { get; set; }
        public string strApelido { get; set; }
        public string strTeste { get; set; }
        public virtual Bairro Bairro { get; set; }
    }
}
