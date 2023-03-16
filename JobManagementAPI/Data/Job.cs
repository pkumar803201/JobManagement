using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobManagementUI.Data
{
    public class Job
    {
        [Key]
        public int jobId { get; set; }
        [Required]
        public string jobName { get; set; }
        [Required]
        public string creator { get; set; }
        [Required]
        public string pdfName { get; set; }
        [Required]
        public string FromEmail { get; set; }
        [Required]
        public string subject { get; set; }
        [Required]
        public string body { get; set; }
        [Required]
        public string scheduleType { get; set; }
        [Required]
        public DateTime scheduleDate { get; set; }
        [Required]
        public string status { get; set; }
        public bool isActice { get; set; }
    }
}
