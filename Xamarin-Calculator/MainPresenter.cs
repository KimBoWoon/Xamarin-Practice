using System;

namespace Xamarin_Calculator
{
    public class MainPresenter : UserAction
    {
        private View view;
        private MainModel mMainModel;

        public MainPresenter(View view)
        {
            this.view = view;
            this.mMainModel = new MainModel();
        }

        public void resultButtonClicked(int val1, int val2, char op)
        {
            view.setResult(String.Format("{0}", mMainModel.calculation(val1, val2, op)));
        }
    }
}