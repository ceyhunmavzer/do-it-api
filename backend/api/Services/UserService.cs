using api.Contracts;
using api.Models;
using api.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Services
{
    public class UserService
    {

        private readonly IDbContext _ctx;

        public UserService(IDbContext ctx)
        {
            _ctx = ctx;
        }

        

        public Pagination<User> GetUsers(PaginationQuery query)
        {
            var users = this._ctx.Users
                .Skip(query.PageIndex * query.PageSize)
                .Take(query.PageSize) ?? new List<User>();

            return new Pagination<User>()
            {
                Items = users.ToList(),
                PageIndex = query.PageIndex,
                PageSize = query.PageSize,
                Count = this._ctx.Users.Count()
            };
        }
    }
}
