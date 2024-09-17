using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace MunicipalityServices
{
    public partial class Form1 : MaterialForm
    {
        private MaterialSkinManager materialSkinManager;

        public Form1()
        {
            InitializeComponent();

            // Initialize MaterialSkinManager
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            // Load and apply the saved theme on startup
            string savedTheme = LoadSavedTheme(); // Calls method to load theme from file
            if (savedTheme == "DARK")
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                toggleThemeSwitch.Checked = true; // Assuming toggleThemeSwitch is your theme switch control
            }
            else
            {
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                toggleThemeSwitch.Checked = false;
            }

            // Set default color scheme
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
        }

        // Event handler for toggling theme
        private void toggleThemeSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleThemeSwitch.Checked)
            {
                // Switch to Dark theme
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                SaveTheme("DARK");
            }
            else
            {
                // Switch to Light theme
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                SaveTheme("LIGHT");
            }
        }

        // Method to save theme preference to text file
        private void SaveTheme(string theme)
        {
            // Define file path where theme preferences will be saved
            string filePath = "theme.txt";

            // Write the selected theme (DARK or LIGHT) to the text file
            File.WriteAllText(filePath, theme);
        }

        // Method to load saved theme from text file
        private string LoadSavedTheme()
        {
            // Define file path where theme preferences are saved
            string filePath = "theme.txt";

            // Check if the theme file exists, if not default to LIGHT theme
            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath); // Read the theme from the file
            }

            return "LIGHT"; // Default theme if no file is found
        }

        // Event handler to open ReportIssuesForm (Form2)
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            ReportIssuesForm reportForm = new ReportIssuesForm(materialSkinManager.Theme); // Pass theme to Form2
            reportForm.Show(); // Display the ReportIssuesForm
        }

        // Event handler for exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
