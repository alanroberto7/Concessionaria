using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class DBCONCESSIONARIA : System.Data.Entity.DbContext
    {
        public DBCONCESSIONARIA() : base("name=DBCONCESSIONARIAEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<VEI001_MARCA> VEI001_MARCA { get; set; }
        public virtual DbSet<VEI002_MODELO> VEI002_MODELO { get; set; }
        public virtual DbSet<VEI003_COMBUSTIVEL> VEI003_COMBUSTIVEL { get; set; }
        public virtual DbSet<VEI004_MODELO_VERSAO> VEI004_MODELO_VERSAO { get; set; }
        public virtual DbSet<VND001_VENDEDOR> VND001_VENDEDOR { get; set; }
        public virtual DbSet<VND002_VENDA> VND002_VENDA { get; set; }

        public virtual ObjectResult<ListarComissoesVendedores_Result> ListarComissoesVendedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ListarComissoesVendedores_Result>("ListarComissoesVendedores");
        }


    }
}
