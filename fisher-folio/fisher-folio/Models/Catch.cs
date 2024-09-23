namespace fisher_folio.Models
{
    public class Catch
    {
        // Nøgler
        public int CatchId { get; set; }    // Primary key
        public int UserId { get; set; }     // Forrent key
        public User User { get; set; }      // Relation. En user kan have flere catch. 

        public string FishSpecies { get; set; }
        public string Location { get; set; }
        public DateTime CatchDate { get; set; }
    }
}
