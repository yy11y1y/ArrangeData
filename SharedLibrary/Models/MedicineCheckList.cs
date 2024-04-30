using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SharedLibrary.Models
{
   public class MedicineCheckList
    {
        [Required]
        public int No { get; set; }
        [Required]
        public int Id { get; set; }
        [Required]
        public string MedicineName { get; set; } = string.Empty;
        public string ImageUrl { get; set; }
        [Required]
        public string Instruction { get; set; } = string.Empty;
        [Required]
        public int EachDosage { get; set; }
        [Required]
        public string UnitOfEachDosage { get; set; }
        public bool DidOrDidntTakeMedicine { get; set; }
        public string SymptomDescription { get; set; }
        [Required]
        public string Operator { get; set; }
        [Required]
        public DateTime OperationTime { get; set; }
    }
}