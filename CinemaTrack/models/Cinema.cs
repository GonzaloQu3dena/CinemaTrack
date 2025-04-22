namespace CinemaTrack.models
{
    /// <summary>
    /// Represents a cinema entity with basic information such as code, name, 
    /// room count, address, manager and area in square meters.
    /// </summary>
    public class Cinema
    {
        /// <summary>
        /// Unique identifier for the cinema.
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// Name of the cinema.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Number of rooms or theathers in the cinema.
        /// </summary>
        public int RoomCount { get; set; }
        /// <summary>
        /// Address where the cinema is located.
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Name of the cinema manager.
        /// </summary>
        public string Manager { get; set; }
        /// <summary>
        /// Number of rooms or theaters in the cinema.
        /// </summary>
        public double AreaInSquareMeters { get; set; }
    }
}
