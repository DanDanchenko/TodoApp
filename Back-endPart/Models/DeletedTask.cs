using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_endPart
{
    public class DeletedTask
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]

        public bool IsCompleted { get; set; }

        [Required]

        public DateTime DeleteTime { get; set; }


    }
}
