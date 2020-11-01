using Microsoft.EntityFrameworkCore;
using Ordering.Core.Enitites;
using Ordering.Core.Repository;
using Ordering.Infrastructure.Data;
using Ordering.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(OrderContext dbcontext) : base(dbcontext)
        {

        }

        public async Task<IEnumerable<Order>> GetOderByUserName(string userName)
        {
            var orderList = await _dbContext.Orders
                                        .Where(o => o.UserName == userName)
                                        .ToListAsync();
            return orderList;
        }
    }
}
