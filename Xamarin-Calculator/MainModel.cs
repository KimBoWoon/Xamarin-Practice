using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Xamarin_Calculator
{
    class MainModel
    {
        public int calculation(int val1, int val2, char op)
        {
            switch (op)
            {
                case '+':
                    return val1 + val2;
                case '-':
                    return val1 - val2;
                case '*':
                    return val1 * val2;
                case '/':
                    return val1 / val2;
                default:
                    return -1;
            }
        }
    }
}