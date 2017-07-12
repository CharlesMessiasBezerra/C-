using System;
using System.Collections.Generic;

namespace CrudEF.Models
{
    public partial class Bairro
    {
        public Bairro()
        {
            this.Clientes = new List<Cliente>();
        }

        public int pk_intCod { get; set; }
        public string strNOME { get; set; }
        public string strcep { get; set; }


        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
