using System;

using Windows.UI.Xaml.Controls;



namespace BaiTest
{
    
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            // lay so vi tri so 42
            int result = Calculate(42);
            tbNumber.Text = result.ToString();
        }

        public int Calculate(int numberial)
        {
            try
            {
                int n = 1;
                int needNumbers = 0;
                for (int i = 10000; n <= numberial; i++)
                {
                    string strNumber = i.ToString();

                    int totalNumber = 0;
                    foreach (char number in strNumber)
                    {
                        totalNumber += (int)Char.GetNumericValue(number);
                    }

                    if (totalNumber == 42)
                    {
                        n++;
                    }
                    if (n == numberial)
                    {
                        needNumbers = i;
                    }
                }
                return needNumbers;

            }
            catch
            {
                return 0;
            }

        }
    }
}
