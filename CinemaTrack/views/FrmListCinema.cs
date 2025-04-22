using CinemaTrack.models;
using CinemaTrack.services;
using System.Windows.Forms;

namespace CinemaTrack.views
{
    /// <summary>
    /// Form that displays a list of all cinemas with options to sort and delete.
    /// </summary>
    public partial class FrmListCinema : Form
    {
        private readonly CinemaService _cinemaService;
        
        /// <summary>
        /// Initializes the form and loads the cinema list.
        /// </summary>
        /// <param name="cinemaService"></param>
        public FrmListCinema(CinemaService cinemaService)
        {
            InitializeComponent();
            _cinemaService = cinemaService;
            LoadCinemas();
        }
        /// <summary>
        /// Loads the current list of cinemas into the DataGridView.
        /// </summary>
        private void LoadCinemas()
        {
            dgvCinemas.DataSource = null;
            dgvCinemas.DataSource = _cinemaService.GetAllCinemas();
        }
        /// <summary>
        /// Handles the click event to sort cinemas by the selected property.
        /// </summary>
        private void btnSort_Click(object sender, System.EventArgs e)
        {
            string property = cmbSortOptions.SelectedItem?.ToString()?.ToLower();

            if (string.IsNullOrEmpty(property))
                return;

            dgvCinemas.DataSource = null;
            dgvCinemas.DataSource = _cinemaService.OrderCinemasBy(property);
        }
        /// <summary>
        /// Handles the click event to delete the selected cinema from the list.
        /// </summary>
        private void btnDeleteSelected_Click(object sender, System.EventArgs e)
        {
            if (dgvCinemas.CurrentRow == null)
                return;

            var selectedCinema = dgvCinemas.CurrentRow.DataBoundItem as Cinema;

            if (selectedCinema == null)
                return;

            _cinemaService.RemoveCinema(selectedCinema.Code);
            lblMessage.Text = $"Cinema '{selectedCinema.Name}' removed.";

            LoadCinemas();
        }
    }
}
