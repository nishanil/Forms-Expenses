using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloForms
{
    public partial class ExpensesPage : ContentPage
    {
        ExpensesViewModel vm;
        public ExpensesPage()
        {
            InitializeComponent();
            BindingContext = vm = new ExpensesViewModel();

            ToolbarItems.Add(new ToolbarItem("Add", null, () => { Navigation.PushAsync(new EditExpensePage()); }));

        }

        protected override void OnAppearing()
        {
            vm.RefreshExpenses();
        }
    }
}
