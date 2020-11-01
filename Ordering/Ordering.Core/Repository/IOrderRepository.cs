using Ordering.Core.Enitites;
using Ordering.Core.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Core.Repository
{
    public interface IOrderRepository : IRepository<Order>
    {
        Task<IEnumerable<Order>> GetOderByUserName(string userName);
        
    }
}
