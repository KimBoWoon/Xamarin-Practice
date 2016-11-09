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
        private EditText val2_edit;
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
            val2_edit = (EditText)FindViewById(Resource.Id.main_val2_edit);
            result_sum = (Button)FindViewById(Resource.Id.main_result_btn);
            sum_result = (TextView)FindViewById(Resource.Id.main_result_text);

            result_sum.Click += sumButtonClicked;
        }

        private void sumButtonClicked(object o, EventArgs e)
        {
            int val1 = Int32.Parse(val1_edit.Text);
            int val2 = Int32.Parse(val2_edit.Text);

            sum_result.Text = String.Format("Result : {0}", val1 + val2);
        }
    }
}

