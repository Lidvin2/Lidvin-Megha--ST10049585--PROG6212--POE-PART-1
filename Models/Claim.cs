using System.ComponentModel.DataAnnotations;

namespace PROG6212_POEPART1.Models
{
    public class Claim
    {
        public int ClaimID { get; set; }
        public int LecturerID { get; set; }
        public string ClaimDate { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
    }
}
