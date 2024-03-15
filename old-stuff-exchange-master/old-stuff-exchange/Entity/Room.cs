using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Old_stuff_exchange.Entity
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        [Required]
        public string RoomName { get; set; }
        public int RoomFloor { get; set; }

        public int BuildingId { get; set; }
        [ForeignKey("BuildingId")]

        public Building Building { get; set; }
    }
}
