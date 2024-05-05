using System.ComponentModel.DataAnnotations;

namespace zad2.Data {
    public class Game {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Relese { get; set; }
        public float Rate { get; set; }

    }
}
