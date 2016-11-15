using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Xamarin_Practice.ViewModel
{
    class CalculatorViewModel : INotifyPropertyChanged
    {
        string inputString1 = "";
        string inputString2 = "";
        string resultString = "";
        string opCode = "+";
        string displayText1 = "";
        string displayText2 = "";
        bool inputTextFlag = true;

        public event PropertyChangedEventHandler PropertyChanged;

        // Constructor
        public CalculatorViewModel()
        {
            this.AddCharCommand = new Command<string>((key) =>
            {
                // Add the key to the input string.
                this.InputString += key;
            });

            this.InputTextCommand = new Command(() =>
            {
                inputTextFlag = !inputTextFlag;
            });

            this.ClaerCommand = new Command(() =>
            {
                this.InputString = "";
            });

            this.GetOperationCode = new Command<string>((op) =>
            {
                this.opCode = op;
            });

            this.GetCalculatorResult = new Command(() =>
            {
                int val1 = Int32.Parse(inputString1);
                int val2 = Int32.Parse(inputString2);

                switch (opCode)
                {
                    case "+":
                        this.ResultDisplay = String.Format("{0}", val1 + val2);
                        break;
                    case "-":
                        this.ResultDisplay = String.Format("{0}", val1 - val2);
                        break;
                    case "*":
                        this.ResultDisplay = String.Format("{0}", val1 * val2);
                        break;
                    case "/":
                        if (val2 == 0)
                        {
                            return;
                        }
                        this.ResultDisplay = String.Format("{0:F9}", val1 / val2);
                        break;
                    default:
                        break;
                }
            });
        }

        public string InputString
        {
            protected set
            {
                if (inputTextFlag)
                {
                    inputString1 = value;
                    this.DisplayText1 = String.Format("{0}", inputString1);
                }
                else
                {
                    inputString2 = value;
                    this.DisplayText2 = String.Format("{0}", inputString2);
                }

                OnPropertyChanged("InputString");
            }

            get
            {
                if (inputTextFlag)
                {
                    return inputString1;
                }
                else
                {
                    return inputString2;
                }
            }
        }

        public string DisplayText1
        {
            protected set
            {
                if (displayText1 != value)
                {
                    displayText1 = value;
                    OnPropertyChanged("DisplayText1");
                }
            }
            get { return displayText1; }
        }

        public string DisplayText2
        {
            protected set
            {
                if (displayText2 != value)
                {
                    displayText2 = value;
                    OnPropertyChanged("DisplayText2");
                }
            }
            get { return displayText2; }
        }

        public string ResultDisplay
        {
            protected set
            {
                resultString = value;
                OnPropertyChanged("ResultDisplay");
            }

            get
            {
                return resultString;
            }
        }

        // ICommand implementations
        public ICommand AddCharCommand { protected set; get; }

        public ICommand DeleteCharCommand { protected set; get; }

        public ICommand InputTextCommand { protected set; get; }

        public ICommand GetOperationCode { protected set; get; }

        public ICommand ClaerCommand { protected set; get; }

        public ICommand GetCalculatorResult { protected set; get; }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
        }
    }
}
