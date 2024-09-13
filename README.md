
```
# ASP.NET Web Forms CRUD Application

A simple ASP.NET Web Forms project demonstrating CRUD (Create, Read, Update, Delete) operations with a SQL Server database. The project uses `GridView` for displaying data and controls like `TextBox` and `Button` for user input.

## Features
- **Insert**: Add new entries to the database.
- **Update**: Modify existing entries.
- **Delete**: Remove entries from the database.
- **Search**: Search for entries by `Id`.
- **Display**: Automatically show all records in the `GridView` upon page load.

## Technologies
- **ASP.NET Web Forms**
- **SQL Server (LocalDB)**
- **C#**
- **ADO.NET** for database interactions

## Prerequisites
- **Visual Studio**
- **SQL Server or LocalDB**

## Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/keyurbhatiya/crud_opration_using_asp.net.git
cd crud_opration_using_asp.net
```

### 2. Database Setup
1. Create a new LocalDB database or use the provided `condata.mdf` file.
2. Ensure the connection string in the code matches the path to your `condata.mdf` file:
    ```csharp
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\condata.mdf;Integrated Security=True");
    ```

### 3. Run the Application
- Open the project in Visual Studio.
- Build the solution.
- Press `F5` or click `Start` to run the application.
- The application will launch in your default web browser.

## Functionality

### Add New Record
1. Fill in the `Id`, `Name`, `Age`, `Address`, and `MobileNo` fields.
2. Click the "Insert" button to add the record.

### Update Record
1. Enter the `Id` of the record to update.
2. Modify the relevant fields (`Name`, `Age`, `Address`, `MobileNo`).
3. Click the "Update" button.

### Delete Record
1. Enter the `Id` of the record to delete.
2. Click the "Delete" button.

### Search Record
1. Enter the `Id` of the record to search.
2. Click the "Search" button.
3. The result will be displayed in the `GridView`.

### Display All Records
All records are displayed in the `GridView` on page load and after any operation.

## Code Overview

- **`Default2.aspx.cs`**: Contains all event handlers and logic for CRUD operations.
- **`disp_data()`**: Fetches and displays all records in the `GridView`.
- **`Blank_Textbox()`**: Clears input fields after a successful operation.

## Error Handling
Each button click is wrapped in a try-catch block. If an error occurs, an alert is displayed with the error message.


## Contact
- **Author**: Keyur Bhatiya
- **GitHub**: [keyurbhatiya](https://github.com/keyurbhatiya)


