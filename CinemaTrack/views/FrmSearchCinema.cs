using System.Linq;
using CinemaTrack.services;
using System.Windows.Forms;

namespace CinemaTrack.views
{
    /// <summary>
    /// Form that allows users to search for cinemas by a specific property.
    /// </summary>
    public partial class FrmSearchCinema : Form
    {
        private readonly CinemaService _cinemaService;
        
        /// <summary>
        /// Initializes the form and sets up the search service. 
        /// </summary>
        /// <param name="cinemaService">
        /// The cinema service to use.
        /// </param>
        public FrmSearchCinema(CinemaService cinemaService)
        {
            InitializeComponent();
            _cinemaService = cinemaService;
        }
        /// <summary>
        /// Handles the click event to perform a search based on selected property and input.
        /// </summary>
        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            string property = cmbSearchOptions.SelectedItem?.ToString()?.ToLower();

            string value = txtSearchValue.Text;

            if (string.IsNullOrEmpty(property) || string.IsNullOrEmpty(value))
            {
                lblMessage.Text = "Please select a property and enter a value";
                return;
            }

            var results = _cinemaService.SearchCinemas(property, value);

            dgvSearchResults.DataSource = null;
            dgvSearchResults.DataSource = results;

            lblMessage.Text = results.Any()
                ? $"{results.Count} result(s) found."
                : "No results found.";
        }
    }
}
