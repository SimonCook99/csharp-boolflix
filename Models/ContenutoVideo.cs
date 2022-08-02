using System.ComponentModel.DataAnnotations;

namespace csharp_boolflix.Models{
    public class ContenutoVideo{

        [Key]
        public int Id { get; set; }

        public string Titolo { get; set; }
        public int Data { get; set; }
        public bool Novità { get; set; }

        //relazione molti a molti coi generi
        public List<Genere> Generi { get; set; }

        //relazione molti a molti con le playlist
        public List<PlayList> PlayLists { get; set; }
    }
}
