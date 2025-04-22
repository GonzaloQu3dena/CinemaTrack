using System.Linq;
using CinemaTrack.models;
using System.Collections.Generic;

namespace CinemaTrack.repositories
{
    /// <summary>
    /// Repository class that manages the in-memory storate of cinemas.
    /// </summary>
    public class CinemaRepository
    {
        private readonly List<Cinema> _cinemas = new List<Cinema>();

        /// <summary>
        /// Checks if a cinema exists
        /// </summary>
        /// <param name="code">
        /// The unique code of the cinema to check if it exists.
        /// </param>
        /// <returns>
        /// True if cinema exists with the same code.
        /// </returns>
        public bool ExistsByCode(string code)
        {
            return _cinemas.Any(c => c.Code == code);
        }
        /// <summary>
        /// Adds a new cinema to the repository.
        /// </summary>
        /// <param name="cinema">
        /// The cinema to add.
        /// </param>
        public void Add(Cinema cinema)
        {
           _cinemas.Add(cinema);
        }
        /// <summary>
        /// Retrieves all registered cinemas.
        /// </summary>
        /// <returns>
        /// List of all cinemas.
        /// </returns>
        public List<Cinema> GetAll()
        {
            return _cinemas;
        }
        /// <summary>
        /// Removes a cinema by its code.
        /// </summary>
        /// <param name="code">
        /// The unique code of the cinema to remove.
        /// </param>
        public void RemoveByCode(string code)
        {
            var foundCinema = _cinemas.FirstOrDefault(c => c.Code == code);

            if (foundCinema != null) 
                _cinemas.Remove(foundCinema);
        }
        /// <summary>
        /// Find a cinema based on a criterion and a value.
        /// </summary>
        /// <param name="property">
        /// Criteria to search.
        /// </param>
        /// <param name="value">
        /// Value of cinema to look for in the collection.
        /// </param>
        /// <returns></returns>
        public List<Cinema> SearchBy(string property, string value)
        {
            switch(property.ToLower())
            {
                case "name":
                    return _cinemas.Where(c => c.Name.Contains(value)).ToList();
                case "address":
                    return _cinemas.Where(c => c.Address.Contains(value)).ToList();
                case "manager":
                    return _cinemas.Where(c => c.Manager.Contains(value)).ToList();

                default:
                    return new List<Cinema>();
            }
        }
    }
}
