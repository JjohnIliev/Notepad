# Notepad Program Readme

This Notepad program is a simple Windows Forms application created using C#. It allows users to create, save, delete, and retrieve notes from a SQL Server database. Below are the functionalities provided by the program:

## Functionalities

1. **Create Note**:
   - Enter a title and content for the note.
   - Click on the "Save" button to insert the note into the database.
   - A timestamp will be automatically added to the note.

2. **Delete Note**:
   - Enter the title of the note you want to delete.
   - Click on the "Delete" button to remove the note from the database.

3. **Retrieve Note**:
   - Enter the title of the note you want to retrieve.
   - Click on the "Retrieve" button to display the content of the note in the text area.
   - The timestamp of the note will be displayed below the content.

## Prerequisites

- Microsoft SQL Server must be installed.
- .NET Framework for Windows Forms application development.

## Usage

1. Clone or download the repository.

2. Open the solution file in Visual Studio.

3. Modify the connection string in the code to match your SQL Server instance.
   ```csharp
   SqlConnection sq = new SqlConnection(@"Data Source=YOUR_SERVER_NAME; Initial Catalog=YOUR_DATABASE_NAME; Integrated Security=True; Encrypt=False;");
