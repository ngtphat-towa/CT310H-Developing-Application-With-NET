namespace lab_2_3
{
    public partial class frmFlightReservationDetails : Form
    {
        public frmFlightReservationDetails()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTickerNumber.Clear();
            txtPassengerName.Clear();
            txtPassportNumber.Clear();
            lstBoxSource.SelectedItem = null;
            lstBoxDestination.SelectedItem = null;
            dpkerFightDate.Value = DateTime.Now;
            cbFlightClass.SelectedIndex = 0;
            chkListServices.ClearSelected();
            foreach (int i in chkListServices.CheckedIndices)
            {
                chkListServices.SetItemChecked(i, false);
            }
        }

        private void btnVeritfy_Click(object sender, EventArgs e)

        {
            // Validate input
            if (lstBoxSource.SelectedItem == lstBoxDestination.SelectedItem)
            {
                MessageBox.Show("Source and destination cities cannot be the same.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Access and process user input
            string ticketNumber = txtTickerNumber.Text;
            string passengerName = txtPassengerName.Text;
            string passportNumber = txtPassportNumber.Text;
            string sourceCity = lstBoxSource.SelectedItem?.ToString()!;
            string destinationCity = lstBoxDestination.SelectedItem!.ToString()!;
            DateTime flightDate = dpkerFightDate.Value;
            string ticketClass = cbFlightClass.SelectedItem.ToString()!;
            string selectedServices = string.Join(", ", chkListServices.CheckedItems.Cast<string>());

            // Save data to a database, file, or other storage as needed
            // Example using a message box for now:
            MessageBox.Show(
                "Reservation details:\n" +
                $"Ticket Number: {ticketNumber}\n" +
                $"Passenger Name: {passengerName}\n" +
                $"Passport Number: {passportNumber}\n" +
                $"Source City: {sourceCity}\n" +
                $"Destination City: {destinationCity}\n" +
                $"Flight Date: {flightDate:d}\n" +
                $"Ticket Class: {ticketClass}\n" +
                $"Additional Services: {selectedServices}",
                "Reservation Information"
            );
        }

    }
}