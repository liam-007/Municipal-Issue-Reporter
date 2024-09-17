# Municipal-Issue-Reporter

This application allows users to report municipality issues such as road damage, water leaks, electricity issues, and more. Users can submit these issues with descriptions, attachments, and categories. It also includes functionality to toggle between light and dark themes using Material Design themes.

## Features

- **Report Issues**: Submit issues by filling out the form with location, category, description, and attaching a file.
- **View Issues**: Display all reported issues in a data grid.
- **Theme Toggle**: Switch between light and dark themes for the application.
- **Attach Files**: Users can attach files (images, PDFs, etc.) when reporting issues.
- **Multiple Forms**: The application has multiple forms, and the theme selection affects all forms.

## Prerequisites

To run this project, you need the following:

- [Visual Studio](https://visualstudio.microsoft.com/) with .NET support
- [.NET Framework](https://dotnet.microsoft.com/download)
- **MaterialSkin** NuGet Package: To install the MaterialSkin UI framework, run the following in the NuGet Package Manager Console:
  ```bash
  Install-Package MaterialSkin.2
  ```

## Installation

1. Clone the repository or download the source code.
   
   ```bash
   git clone https://github.com/your-repo-link.git
   ```

2. Open the solution in Visual Studio.
3. Install the required NuGet packages by right-clicking on the solution and selecting **Restore NuGet Packages**.
4. Build the solution (`Ctrl + Shift + B`) to ensure everything is set up correctly.
5. Run the application by clicking on the **Start** button or pressing `F5`.

## Usage

1. **Report an Issue**:
   - Open the application.
   - Click the **Report Issues** button.
   - Fill in the **Location**, **Category**, and **Description** fields.
   - Attach a file if necessary by clicking the **Attach** button.
   - Submit the issue by clicking the **Submit** button.

2. **View Reported Issues**:
   - All submitted issues will be displayed in the DataGridView with their location, category, description, and attached file.

3. **Toggle Theme**:
   - You can switch between light and dark themes by using the **Toggle Theme** button. The selected theme will persist across forms.

## Screenshots

### Light Theme:
![light1](https://github.com/user-attachments/assets/05ba78fc-3a4f-4bc7-af50-e1c6f1e4a62d)

![light2](https://github.com/user-attachments/assets/9df2a8d1-af4e-49e0-a72d-0f6dd4de15bb)

### Dark Theme:
![dark1](https://github.com/user-attachments/assets/07b4e6d2-db4c-4f6b-976b-a4244f8c2eee)

![dark2](https://github.com/user-attachments/assets/051c80d9-8289-4502-b629-5ceb043678d4)


## Code Overview

- **Form1.cs**: The main menu form. Contains buttons for navigating to the issue reporting form, toggling themes, and exiting the application.
- **ReportIssuesForm.cs**: The form where users can report issues. It includes validation and displays the reported issues in a DataGridView.
- **MaterialSkinManager**: Manages the application's theme, which is shared across multiple forms.

## Future Enhancements

- Add functionality for **Service Request Status** and **Local Events**.
- Save reported issues to a database or an external file for persistence.
- Improve file attachment features for better validation and security.

## Contributing

Feel free to fork the repository and submit pull requests. Any contributions are welcome!

## License

This project is licensed under the MIT License.

## Contact

For any issues or inquiries, please contact:

- **Liam** - [liamcole0705@gmail.com]


