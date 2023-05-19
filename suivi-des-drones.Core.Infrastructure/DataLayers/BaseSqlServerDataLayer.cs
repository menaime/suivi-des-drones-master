using suivi_des_drones.Core.Infrastructure.Databases;

namespace suivi_des_drones.Core.Infrastructure.DataLayers
{
    /// <summary>
    /// Classe parent pour tous les DataLayers qui vont avoir besoin du context
    /// </summary>
    public abstract class BaseSqlServerDataLayer
    {
        #region Fields
        private readonly BaseSqlServerDataLayer? context = null;
        #endregion
        #region Constructor
        protected BaseSqlServerDataLayer(DronesDbContext context)
        {
            this.context = Context;
        }
        #endregion
        #region Property
        public DronesDbContext Context => Context;

        public static implicit operator BaseSqlServerDataLayer(DronesDbContext v)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
