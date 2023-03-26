namespace TS.Models.Models
{
    public class Ship
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Latitude { get; set; }
        public int Longitude { get; set; }
        public decimal Velocity { get; set; }
    }
}