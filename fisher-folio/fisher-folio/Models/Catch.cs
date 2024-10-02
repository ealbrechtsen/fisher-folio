using System.ComponentModel.DataAnnotations;

namespace fisher_folio.Models
{
    public class Catch
    {
        // Nøgler
        public int CatchId { get; set; }    // Primary key
        public int UserId { get; set; }     // Forrent key
        public User User { get; set; }      // Relation. En user kan have flere catch. 

        [Required]
        public string FishSpecies { get; set; }

        [Required]        
        public string Location { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime CatchDate { get; set; }
    }
}
