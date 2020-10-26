using api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Storage
{
    public interface IDbContext
    {
        ICollection<User> Users { get; set; }
    }
}
