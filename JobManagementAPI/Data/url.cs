using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobManagementUI.Data
{
    public class url
    {
        [Key]
        public int urlId { get; set; }
        [Required]
        public string Url { get; set; }


        // Foreign key 
        public int jobId { get; set; }

        [ForeignKey("jobId")]
        public Job job { get; set; }

    }
}
