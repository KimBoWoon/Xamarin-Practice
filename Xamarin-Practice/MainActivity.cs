using Android.App;
using Android.Widget;
using Android.OS;
using System;
//using Xamarin.Forms;

namespace Xamarin_Practice
{
    [Activity(Label = "Xamarin_Practice", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private EditText val1_edit;
        private EditText val2_edit;
        private Button result_btn;
        private TextView result_sum;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            initView();
        }

        private void initView() {
            val1_edit = (EditText)FindViewById(Resource.Id.main_val1_edit);
            val2_edit = (EditText)FindViewById(Resource.Id.main_val2_edit);
            result_btn = (Button)FindViewById(Resource.Id.main_result_sum_btn);
            result_sum = (TextView)FindViewById(Resource.Id.main_result_sum_text);
            
            result_btn.Click += OnButtonClicked;
        }

        private void OnButtonClicked(object o, EventArgs e)
        {
            result_sum.Text = "3";
        }
    }
}

