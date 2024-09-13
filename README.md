# crud_opration_using_asp.net
Here is a sample `README.md` file for your ASP.NET Web Forms project:

```markdown
# ASP.NET Web Forms CRUD Application

This is a simple ASP.NET Web Forms project demonstrating CRUD (Create, Read, Update, Delete) operations using a SQL Server database. The project uses `GridView` for displaying data and several controls like `TextBox` and `Button` to handle user inputs.

## Features
- **Insert Data**: Add new entries to the database.
- **Update Data**: Modify existing entries.
- **Delete Data**: Remove entries from the database.
- **Search Data**: Search for entries by `Id`.
- **Display Data**: Automatically show all entries in the `GridView`.

## Technologies Used
- ASP.NET Web Forms
- SQL Server (LocalDB)
- C#
- ADO.NET for database interactions

## Prerequisites
- Visual Studio
- SQL Server or LocalDB

## Getting Started

### 1. Clone the repository
```bash
git clone https://github.com/keyurbhatiya/crud_opration_using_asp.net.git
cd aspnet-crud-app


### 2. Database Setup
The project uses SQL Server LocalDB for storing data.

1. Create a new LocalDB database or attach the provided `condata.mdf` file.
2. Ensure that the connection string in the code matches the path to your `condata.mdf` file:
    ```csharp
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
    ```

### 3. Run the Application
- Open the project in Visual Studio.
- Build the solution.
- Run the project by pressing `F5` or clicking `Start` in Visual Studio.
- The application will open in your default web browser.

### 4. Functionality

#### Add New Record
1. Fill in the `Id`, `Name`, `Age`, `Address`, and `MobileNo` fields.
2. Click the "Insert" button to add the record to the database.

#### Update Record
1. Enter the `Id` of the record you wish to update.
2. Modify the `Name`, `Age`, `Address`, and `MobileNo` fields.
3. Click the "Update" button.

#### Delete Record
1. Enter the `Id` of the record you wish to delete.
2. Click the "Delete" button.

#### Search Record
1. Enter the `Id` of the record you wish to search for.
2. Click the "Search" button.
3. The result will be displayed in the `GridView`.

#### Display All Records
- Upon loading, the application will automatically display all records in the `GridView`.

## Code Overview

- **Default2.aspx.cs**: Contains all the event handlers and logic for CRUD operations.
- **disp_data()**: Fetches and displays all records in the `GridView`.
- **Blank_Textbox()**: Clears the input fields after a successful operation.

## Error Handling
Error handling is performed in each button click event. If an error occurs, an alert message will be displayed.
```
