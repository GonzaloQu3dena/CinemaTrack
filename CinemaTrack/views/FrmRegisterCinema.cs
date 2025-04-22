using System;
using CinemaTrack.models;
using CinemaTrack.services;
using System.Windows.Forms;

namespace CinemaTrack.views
{
    /// <summary>
    /// Form that allows users to register a new cinema.
    /// </summary>
    public partial class FrmRegisterCinema : Form
    {
        private readonly CinemaService _cinemaService;

        /// <summary>
        /// Initializes the form and injects the service layer.
        /// </summary>
        /// <param name="cinemaService">
        /// The cinema service to use.
        /// </param>
        public FrmRegisterCinema(CinemaService cinemaService)
        {
            InitializeComponent();
            _cinemaService = cinemaService;
        }
        /// <summary>
        /// Handles the click event to register a new cinema using user input.
        /// </summary>
        private void btnRegisterCinema_Click(object sender, EventArgs e)
        {
            var cinema = new Cinema
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Address = txtAddress.Text,
                Manager = txtManager.Text,
                RoomCount = int.Parse(txtRooms.Text),
                AreaInSquareMeters = double.Parse(txtArea.Text)
            };

            string result = _cinemaService.RegisterCinema(cinema);
            lblMessage.Text = result;
        }
    }
}
