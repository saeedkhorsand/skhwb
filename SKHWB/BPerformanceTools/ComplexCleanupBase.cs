using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SKHWB.BPerformanceTools
{
    public abstract class ComplexCleanupBase:IDisposable
    {
        private bool Disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);/* :| */
        }
        protected virtual void Dispose(bool Disposing)
        {
            if (!Disposed)
            {
                if (Disposing)
                {
                    fCleanUp();
                }
                Disposed = true;
            }
        }
        public abstract bool fCleanUp();
    }
}
