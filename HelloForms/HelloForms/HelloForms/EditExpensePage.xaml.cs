using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloForms
{
    public partial class EditExpensePage : ContentPage
    {
        public EditExpensePage()
        {
            InitializeComponent();
            BindingContext = new EditExpenseViewModel(Navigation);
        }
    }
}
