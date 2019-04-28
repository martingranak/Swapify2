using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApp.Repository
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TodoApp.Models;

    public interface ITodoRepository
    {
        // api/[GET]
        Task<IEnumerable<Todo>> GetAllTodos();

        // api/1/[GET]
        Task<Todo> GetTodo(long id);

        // api/[POST]
        Task Create(Todo todo);

        // api/[PUT]
        Task<bool> Update(Todo todo);

        // api/1/[DELETE]
        Task<bool> Delete(long id);

        Task<long> GetNextId();
    }
}
