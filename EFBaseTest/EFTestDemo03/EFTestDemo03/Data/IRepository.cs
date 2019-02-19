using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTestDemo03.Data
{
    public partial interface IRepository<T> where T : BaseEntity
    {
        /// <summary>
        /// Get Entity by id
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Entity</returns>
        T GetById(object id);

        /// <summary>
        /// insert entity
        /// </summary>
        /// <param name="entity"></param>
        void Insert(T entity);

        /// <summary>
        /// Insert Entity with Return Value
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int InsertHaveReturnVal(T entity);

        /// <summary>
        /// Insert entities
        /// </summary>
        /// <param name="entities">entities</param>
        /// <returns></returns>
        void Insert(IEnumerable<T> entities);

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity">Entity</param>
        void Update(T entity);

        /// <summary>
        /// Update entities
        /// </summary>
        /// <param name="entities">entities</param>
        void Update(IEnumerable<T> entities);

        /// <summary>
        /// Delete entity
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// Delete entities
        /// </summary>
        /// <param name="entities"></param>
        void Delete(IEnumerable<T> entities);

        /// <summary>
        /// Get a table
        /// </summary>
        IQueryable<T> Table { get; }
    }
}
