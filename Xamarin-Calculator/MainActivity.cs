using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Xamarin_Calculator
{
    [Activity(Label = "Xamarin_Calculator", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity, View
    {
        private bool flag;
        private char op;
        private TextView val1_edit;
        private TextView val2_edit;
        private Button result_btn;
        private TextView result_text;
        private UserAction mMainPresenter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            initView();
        }

        public void initView()
        {
            mMainPresenter = new MainPresenter(this);

            flag = false;

            val1_edit = (TextView)FindViewById(Resource.Id.main_val1_text);
            val2_edit = (TextView)FindViewById(Resource.Id.main_val2_text);
            result_btn = (Button)FindViewById(Resource.Id.main_result_btn);
            result_text = (TextView)FindViewById(Resource.Id.main_result_text);

            this.FindViewById(Resource.Id.main_num0_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num1_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num2_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num3_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num4_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num5_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num6_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num7_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num8_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_num9_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_next_btn).Click += getNumber;
            this.FindViewById(Resource.Id.main_cls_btn).Click += getNumber;

            this.FindViewById(Resource.Id.main_plus_btn).Click += getOperation;
            this.FindViewById(Resource.Id.main_minus_btn).Click += getOperation;
            this.FindViewById(Resource.Id.main_multiple_btn).Click += getOperation;
            this.FindViewById(Resource.Id.main_division_btn).Click += getOperation;

            result_btn.Click += resultButtonClicked;
        }

        private void resultButtonClicked(object o, EventArgs e)
        {
            if (val1_edit.Text == "" || val2_edit.Text == "")
            {
                Toast.MakeText(this.ApplicationContext, "숫자를 입력해 주세요", ToastLength.Short).Show();
                return;
            }

            int val1 = Int32.Parse(val1_edit.Text);
            int val2 = Int32.Parse(val2_edit.Text);

            val1_edit.Text = "";
            val2_edit.Text = "";

            mMainPresenter.resultButtonClicked(val1, val2, op);
        }

        private void getNumber(object o, EventArgs e)
        {
            switch (((Button)o).Id)
            {
                case Resource.Id.main_num0_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num1_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num2_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num3_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num4_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num5_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num6_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num7_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num8_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_num9_btn:
                    if (!flag)
                    {
                        val1_edit.Text = val1_edit.Text + ((Button)o).Text;
                    }
                    else
                    {
                        val2_edit.Text = val2_edit.Text + ((Button)o).Text;
                    }
                    break;
                case Resource.Id.main_next_btn:
                    flag = !flag;
                    break;
                case Resource.Id.main_cls_btn:
                    val1_edit.Text = "";
                    val2_edit.Text = "";
                    break;
                default:
                    break;
            }
        }

        public void getOperation(object o, EventArgs e)
        {
            switch (((Button)o).Id)
            {
                case Resource.Id.main_plus_btn:
                    op = '+';
                    break;
                case Resource.Id.main_minus_btn:
                    op = '-';
                    break;
                case Resource.Id.main_multiple_btn:
                    op = '*';
                    break;
                case Resource.Id.main_division_btn:
                    if (val2_edit.Text == "0")
                    {
                        Toast.MakeText(this.ApplicationContext, "0으로 나눌 수 없습니다!", ToastLength.Short).Show();
                        return;
                    }
                    op = '/';
                    break;
                default:
                    break;
            }
        }

        public void setResult(string s)
        {
            result_text.Text = s;
        }
    }
}

