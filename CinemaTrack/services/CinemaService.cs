using System;
using System.Linq;
using CinemaTrack.models;
using CinemaTrack.repositories;
using System.Collections.Generic;

namespace CinemaTrack.services
{
    /// <summary>
    /// Provides business logic and operations related to cinema management.
    /// </summary>
    public class CinemaService
    {
        private readonly CinemaRepository _repository;

        /// <summary>
        /// Initializes the service with a given repository.
        /// </summary>
        /// <param name="repository">
        /// The repository to use for storage operations.
        /// </param>
        public CinemaService(CinemaRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Registers a new cinema if its code does not already exist.
        /// </summary>
        /// <param name="cinema">
        /// The cinema to register.
        /// </param>
        /// <returns>
        /// Message indicating success or duplicate code error.
        /// </returns>
        public string RegisterCinema(Cinema cinema)
        {
            if (_repository.ExistsByCode(cinema.Code))
                return "Cinema code already exists";

            _repository.Add(cinema);

            return "Cinema registered successfully";
        }
        /// <summary>
        /// Retrieves all cinemas stored in the system.
        /// </summary>
        /// <returns>
        /// List of all cinemas.
        /// </returns>
        public List<Cinema> GetAllCinemas()
        {
            return _repository.GetAll();
        }
        /// <summary>
        /// Removes a cinema identified by its code.
        /// </summary>
        /// <param name="code">
        /// The unique code of the cinema.
        /// </param>
        public void RemoveCinema(string code)
        {
            _repository.RemoveByCode(code);
        }
        /// <summary>
        /// Searches cinemas by a given property and value.
        /// </summary>
        /// <param name="property">
        /// The property to search by (name, area, etc).
        /// </param>
        /// <param name="value">
        /// The value to search for.
        /// </param>
        /// <returns>
        /// List of cinemas that match the criteria.
        /// </returns>
        public List<Cinema> SearchCinemas(string property, string value)
        {
            return _repository.SearchBy(property, value);
        }
        /// <summary>
        /// Sorts the cinema list by the specified property.
        /// </summary>
        /// <param name="property">
        /// The property to sort by (name, address, manager, etc).
        /// </param>
        /// <returns>
        /// Sorted list of cinemas.
        /// </returns>
        public List<Cinema> OrderCinemasBy(string property)
        {
            var cinemas = _repository.GetAll();

            var orderingMap = 
                new Dictionary<string, Func<Cinema, object>>(StringComparer.OrdinalIgnoreCase)
            {
                { "name", c => c.Name },
                { "address", c => c.Address },
                { "manager", c => c.Manager },
                { "roomcount", c => c.RoomCount },
                { "area", c => c.AreaInSquareMeters }
            };

            return orderingMap.ContainsKey(property) ? cinemas.OrderBy(orderingMap[property]).ToList() : cinemas;
        }
    }
}
