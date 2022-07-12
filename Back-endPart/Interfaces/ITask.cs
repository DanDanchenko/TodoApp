using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_endPart.Interfaces
{
    internal interface ITask
    {
        public interface ITask : IDisposable
        {
            IEnumerable<Task> GetTasksList();

            Task GetTask(int id);

            void Add(Task task);

            void Update(Task task);

            void Delete (Task task);

            void Save();

        }
    }
}
