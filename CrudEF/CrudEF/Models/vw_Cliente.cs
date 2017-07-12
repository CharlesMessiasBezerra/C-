using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudEF.Models
{
    public class vw_Cliente
    {
        public Int32 pk_intCod { get; set; }        
        public string strNOME { get; set; }
        public string strNOMEB { get; set; }
        public int? intIdade { get; set; }
        public string strSexo { get; set; }
        public string StrApelido { get; set; }
        public string strcep { get; set; }

    }
}
