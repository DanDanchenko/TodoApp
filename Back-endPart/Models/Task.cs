using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Back_endPart
{

    public enum Priorities {Low, Medium, Heigh}

    public class Task
    {
      public  int Id { get; set; }

        [Required]
        [MaxLength(50)]
       public  string Title { get; set; }

        [Required]
        public Priorities Priority { get; set; }

        [Required]

       public DateTime DeadLineDate { get; set; }

        [Required]
        [MaxLength(500)]

      public string Description { get; set; }

        [Required]

       public bool IsCompleted { get; set; }






    }
}