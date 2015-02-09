using HelloForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloForms.Data
{
    class ExpensesDatabase
    {
        
        SQLite.SQLiteConnection connection;
        static object locker = new object();

        public ExpensesDatabase()
        {
            connection = DependencyService.Get<ISQLite>().GetConnection();
            connection.CreateTable<Model.ExpenseItem>();
        }
       
        public List<ExpenseItem> GetExpenses()
        {
            lock (locker)
            {
                return (from i in connection.Table<Model.ExpenseItem>() select i).ToList();
            }
        }

       public int SaveExepnse(ExpenseItem expenseItem)
        {
            lock (locker)
            {
                if (expenseItem.ID != 0)
                {
                    connection.Update(expenseItem);
                    return expenseItem.ID;
                }
                else
                {
                    return connection.Insert(expenseItem);
                }
            }
        }

        public ExpenseItem GetExpense(int id)
        {
            lock (locker)
            {
                return connection.Table<Model.ExpenseItem>().FirstOrDefault(x => x.ID == id);
            }
        }
    }
}
