using System;
using CinemaTrack.services;
using System.Windows.Forms;
using CinemaTrack.repositories;

namespace CinemaTrack.views
{
    /// <summary>
    /// Main form used as the navigation menu for the Cinema Management System.
    /// </summary>
    public partial class FrmMain : Form
    {

        private readonly CinemaService _cinemaService;
        private readonly CinemaRepository _cinemaRepository = new CinemaRepository();

        public FrmMain()
        {
            InitializeComponent();
            _cinemaService = new CinemaService(_cinemaRepository);
        }
        /// <summary>
        /// Opens the registration form.
        /// </summary>
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Form form = new FrmRegisterCinema(_cinemaService);
            form.ShowDialog();
        }
        /// <summary>
        /// Opens the list/delete form.
        /// </summary>
        private void btnList_Click(object sender, EventArgs e)
        {
            Form form = new FrmListCinema(_cinemaService);
            form.ShowDialog();
        }
        /// <summary>
        /// Opens the search form.
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Form form = new FrmSearchCinema(_cinemaService);
            form.ShowDialog();
        }
    }
}
