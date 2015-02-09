using HelloForms.Data;
using HelloForms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloForms
{
    public class ExpensesViewModel : ObservableObject
    {
        ExpensesDatabase db;

        public ExpensesViewModel()
        {
            db = new ExpensesDatabase();
        }
        private List<ExpenseItem> expenses;

        public List<ExpenseItem> Expenses
        {
            get { return expenses; }
            set { expenses = value; OnPropertyChanged(); }
        }
        

        public void RefreshExpenses()
        {
            Expenses = db.GetExpenses();
        }
    }
}
