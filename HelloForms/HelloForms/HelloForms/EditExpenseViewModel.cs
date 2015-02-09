using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using HelloForms.Data;
using HelloForms.Model;

namespace HelloForms
{
    public class EditExpenseViewModel
    {
        public string Name { get; set; }
        public double Amount { get; set; }

        public ICommand SaveCommand { get; set; }

        public EditExpenseViewModel(INavigation navigation)
        {
            SaveCommand = new Command(() =>
            {
                new ExpensesDatabase().SaveExepnse(new ExpenseItem { Name=Name, Amount= Amount });

                navigation.PopAsync();
            });
        }

    }
}
