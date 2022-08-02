using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models{
    public class Profilo{
        
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Nome { get; set; }
        public bool IsBambino { get; set; }

        //relazione 1 a molti con le playlists
        public List<PlayList> PlayLists { get; set; }
    }
}
