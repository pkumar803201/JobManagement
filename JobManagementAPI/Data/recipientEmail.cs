using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobManagementUI.Data
{
    public class recipientEmail
    {
        [Key]
        public int  mailId { get; set; }
        [Required]
        public string Email { get; set; }

        // Foreign key 
        public int jobId { get; set; }

        [ForeignKey("jobId")]
        public Job job { get; set; }
    }
}
