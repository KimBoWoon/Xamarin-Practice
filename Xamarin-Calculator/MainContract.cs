namespace Xamarin_Calculator
{
    public interface View
    {
        void initView();
        void setResult(string s);
    }
    public interface UserAction
    {
        void resultButtonClicked(int val1, int val2, char op);
    }
}