using System;
using System.IO;
using Xamarin.Forms;
using SQLite;
using HelloForms.Data;
using HelloForms.iOS;

[assembly: Dependency(typeof(SQLite_iOS))]
namespace HelloForms.iOS
{    // ...
    public class SQLite_iOS : ISQLite
    {
        public SQLite_iOS() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "ExpensesSQLite.db3";
            string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
            string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
            var path = Path.Combine(libraryPath, sqliteFilename);
            // Create the connection
            var conn = new SQLiteConnection(path);
            // Return the database connection
            return conn;
        }
    }
}