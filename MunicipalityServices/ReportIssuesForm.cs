using System;
using System.Collections.Generic; // For List
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MunicipalityServices
{
    public partial class ReportIssuesForm : MaterialForm
    {
        private string attachedFilePath;
        private List<Issues> reportedIssues; // List to store reported issues
        private readonly MaterialSkinManager materialSkinManager;

        // Constructor with theme parameter
        public ReportIssuesForm(MaterialSkinManager.Themes selectedTheme)
        {
            InitializeComponent();

            // Initialize MaterialSkinManager and apply the theme from Form1
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = selectedTheme; // Set the passed theme

            // Set default color scheme (same as Form1)
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);

            reportedIssues = new List<Issues>(); // Initialize the list of reported issues
        }

        // Event handler for the Attach button
        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png|PDF Files|*.pdf|All Files|*.*",
                Title = "Attach a File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                attachedFilePath = openFileDialog.FileName;
                MessageBox.Show($"File attached: {Path.GetFileName(attachedFilePath)}", "File Attached", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Display the image in PictureBox if it's an image file
                if (attachedFilePath.EndsWith(".jpg") || attachedFilePath.EndsWith(".jpeg") || attachedFilePath.EndsWith(".png"))
                {
                    pictureBoxPreview.Image = Image.FromFile(attachedFilePath);
                }
                else
                {
                    pictureBoxPreview.Image = null; // Clear the PictureBox if the file is not an image
                }
            }
        }


        // Event handler for the Submit button
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtLocation.Text))
            {
                MessageBox.Show("Please enter a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(richDescription.Text))
            {
                MessageBox.Show("Please provide a description of the issue.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Process form data
            string location = txtLocation.Text;
            string category = cmbCategory.SelectedItem.ToString();
            string description = richDescription.Text;
            string attachedFile = string.IsNullOrEmpty(attachedFilePath) ? "No file attached" : attachedFilePath;

            // Create a new Issue object and add it to the list
            Issues newIssues = new Issues(location, category, description, attachedFile);
            reportedIssues.Add(newIssues); // Add the new issue to the list

            // Display the new issue in the DataGridView
            DisplayReportedIssues();

            // Clear the form after submission
            ClearForm();
        }

        // Event handler for the Back button
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();
        }

        // Method to clear form fields after submission
        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            richDescription.Clear();
            attachedFilePath = null;
        }

        // Method to display all reported issues in the DataGridView
        private void DisplayReportedIssues()
        {
            dgvReportedIssues.Rows.Clear(); // Clear the DataGridView before adding rows

            // Ensure columns are added once
            if (dgvReportedIssues.Columns.Count == 0)
            {
                dgvReportedIssues.Columns.Add("Location", "Location");
                dgvReportedIssues.Columns.Add("Category", "Category");
                dgvReportedIssues.Columns.Add("Description", "Description");
                dgvReportedIssues.Columns.Add("AttachedFile", "Attached File");
            }

            // Adjust the DataGridView colors based on the theme
            if (materialSkinManager.Theme == MaterialSkinManager.Themes.DARK)
            {
                dgvReportedIssues.BackgroundColor = Color.FromArgb(48, 48, 48); // Dark background
                dgvReportedIssues.DefaultCellStyle.BackColor = Color.FromArgb(48, 48, 48); // Dark row background
                dgvReportedIssues.DefaultCellStyle.ForeColor = Color.White; // Light text color for visibility
                dgvReportedIssues.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(64, 64, 64); // Darker header background
                dgvReportedIssues.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Light header text color
            }
            else
            {
                dgvReportedIssues.BackgroundColor = Color.White; // Light background
                dgvReportedIssues.DefaultCellStyle.BackColor = Color.White; // Light row background
                dgvReportedIssues.DefaultCellStyle.ForeColor = Color.Black; // Dark text color for visibility
                dgvReportedIssues.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray; // Light header background
                dgvReportedIssues.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black; // Dark header text color
            }

            // Add rows to the DataGridView for each reported issue
            foreach (var issue in reportedIssues)
            {
                dgvReportedIssues.Rows.Add(issue.Location, issue.Category, issue.Description, issue.AttachedFile);
            }
        }

    }
}

