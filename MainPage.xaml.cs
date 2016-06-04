using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BaiTest
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            int result = Calculate();
            tbNumber.Text = result.ToString();
        }

        public int Calculate()
        {
            try
            {
                int n = 0;
                int needNumbers = 0;
                for (int i = 10000; n < 42; i++)
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
                    if (n == 41)
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
