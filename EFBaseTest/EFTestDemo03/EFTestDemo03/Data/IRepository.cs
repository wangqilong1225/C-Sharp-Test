using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDemo03.Data
{
    public partial interface IRepository<T> where T : BaseEntity
    {
    }
}
