using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core;
using System.Data.Entity;

namespace Back_endPart.Infrastructure
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }
        public DbSet<DeletedTask> DeletedTasks { get; set; }

        public void Add(DeletedTask deletedTask)
        {
            this.DeletedTasks.Add(deletedTask);
        }

        public void Delete(int id)
        {
            this.DeletedTasks.Remove(this.DeletedTasks.ToList()[id]);
        }

        public IEnumerable<DeletedTask> GetHistoryList()
        {
            return this.DeletedTasks.ToList();
        }

        public int GetCount()
        { return this.DeletedTasks.Count(); }

        public DeletedTask GetDeleted(int id)
        {
            return this.DeletedTasks.ToList()[id];
        }

        public void Save()
        {
            this.SaveChanges();
        }

    }
}
