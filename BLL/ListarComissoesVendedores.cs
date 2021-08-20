using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ListarComissoesVendedores
    {

        public IEnumerable<DAL.ListarComissoesVendedores_Result> GetList()
        {
            using (DAL.DBCONCESSIONARIA bd = new DAL.DBCONCESSIONARIA())
            {
                return bd.ListarComissoesVendedores().ToList();
            }
        }
    }

}
