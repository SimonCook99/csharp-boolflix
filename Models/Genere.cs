using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models{
    public class Genere{
        
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }


        // relazione molti a molti coi contenuti
        public List<ContenutoVideo>? Contenuti { get; set; }


        

    }
}
