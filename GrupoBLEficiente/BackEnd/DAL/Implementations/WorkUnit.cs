using BackEnd.DAL.interfaces;
using BackEnd.Data;

namespace BackEnd.DAL.Implementations
{
    public class WorkUnit<T> : IDisposable where T : class
    {
        private readonly GrupoBLContext context;
        //public IDALGenerico<Queja> quejaDAL;
        //public IDALGenerico<TablaGeneral> tablaDAL;
        public IDALGeneric<T> genericDAL;
        
        public WorkUnit(GrupoBLContext _context)
        {
            context = _context;
            genericDAL = new DALGenericImpl<T>(context);
        }

        public bool Complete()
        {
            try
            {
                context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                string msj = e.Message;
                return false;
            }

        }
        
        public void Dispose()
        {
            context.Dispose();
        }
    }
}