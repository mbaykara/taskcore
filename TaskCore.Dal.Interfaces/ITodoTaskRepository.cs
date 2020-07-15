using System.Collections.Generic;
using TaskCore.Dal.Models;

namespace TaskCore.Dal.Interfaces
{
    public interface ITodoTaskRepository
    {
        TodoTask Get(string taskId);

        IReadOnlyList<TodoTask> GetByCategory(string categoryId);

        void Add(TodoTask task);

        bool Delete(string taskId);
        
    }
}