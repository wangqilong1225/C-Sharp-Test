using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDemo03.Data
{
    public abstract class EFEntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        protected EFEntityTypeConfiguration()
        {
            PostInitialize();
        }
        protected virtual void PostInitialize()
        {

        }
    }
}
