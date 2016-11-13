using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin_Calculator.View
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        void btnClicked(object o, EventArgs e)
        {
            ((Button)o).Text = "Hello";
        }
    }
}
