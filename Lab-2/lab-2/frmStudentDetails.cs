using System.Text;

namespace lab_2
{
    public partial class frmStudentDetails : Form
    {
        public frmStudentDetails()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // StringBuilder for efficient string concatenation
            StringBuilder checkedItemsBuilder = new();
            int checkedItemsCount = lstHob.CheckedItems.Count;
            for (int index = 0; index <= checkedItemsCount - 1; index++)
            {
                checkedItemsBuilder.Append(lstHob.CheckedItems[index]?.ToString());
                if (index < checkedItemsCount - 1)
                {
                    checkedItemsBuilder.Append(", ");
                }
            }

            // Display the checked items in a message box
            MessageBox.Show(txtName.Text + " born in " + txtYear.Text + " from Class: " + lstClass.Text + ", Division: " + cboDiv.Text + " has followings hobbies: " + checkedItemsBuilder);
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            txtName.Text = "";
            txtYear.Text = "";

            // Reset ComboBox to default value
            cboDiv.SelectedIndex = -1;  // Assumes no default value

            // Clear ListBox
            lstClass.Items.Clear();

            // Clear CheckedListBox
            foreach (int i in lstHob.CheckedIndices)
            {
                lstHob.SetItemChecked(i, false);
            }
        }

    }
}