using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back_endPart.Interfaces;

namespace Back_endPart.Infrastructure
{
    public class TaskRepository : ITask
    {
        private TaskContext db;

        public TaskRepository()
        {
            this.db = new TaskContext();
        }

        public  IEnumerable<Task> GetTasksList()
        {
            return db.Tasks.ToList();
        }

        public Task GetTask(int id)
        {
            return db.Tasks.ToList()[id];
        }

        public void Add(Task task)
        {
            db.Tasks.Add(task);
        }

        public void Update(int id, string title, Priorities priority, DateTime deadline, string description, bool iscomp)
        {
            db.Tasks.ToList()[id].Title = title;
            db.Tasks.ToList()[id].Priority = priority;
            db.Tasks.ToList()[id].DeadLineDate = deadline;
            db.Tasks.ToList()[id].Description = description;
            db.Tasks.ToList()[id].IsCompleted = iscomp;

        }

        public void Delete(int id)
        {
          db.Tasks.Remove(db.Tasks.ToList()[id]);
        }

        public void DeleteAll()
        {
            db.Tasks.RemoveRange(db.Tasks.ToList());
        }

        

        public void Save()
        {
            db.SaveChanges();
        }

    }
}
