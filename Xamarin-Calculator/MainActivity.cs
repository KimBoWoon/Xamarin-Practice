using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Xamarin_Calculator
{
    [Activity(Label = "Xamarin_Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private EditText val1_edit;
        private Button result_sum;
        private TextView sum_result;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            initView();
        }

        private void initView()
        {
            val1_edit = (EditText)FindViewById(Resource.Id.main_val1_edit);
            result_sum = (Button)FindViewById(Resource.Id.main_result_btn);
            sum_result = (TextView)FindViewById(Resource.Id.main_result_text);

            result_sum.Click += sumButtonClicked;
        }

        private void sumButtonClicked(object o, EventArgs e)
        {
            sum_result.Text = "3";
        }
    }
}

