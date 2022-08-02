using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models{
    public class PlayList{
        
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Titolo { get; set; }

        //relazione molti a molti coi contenuti
        public List<ContenutoVideo>? Contenuti { get; set; }

        //relazione 1 a molti col profilo (riferimento al profilo specifico)
        public int ProfiloId { get; set; }
        public Profilo Utente { get; set; }
        

    }
}
