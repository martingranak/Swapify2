using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    using MongoDB.Driver;

    public interface ITodoContext
    {
        IMongoCollection<Todo> Todos { get; }
    }
}
