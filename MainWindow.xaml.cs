using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace A002_Factorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txt1.Text);
            LB.Items.Clear();

            var watch = System.Diagnostics.Stopwatch.StartNew();
            long rfact = rFactorial(x);
            watch.Stop(); // 수행시간을 Ticks단위로 알려줌
            var elap = watch.ElapsedTicks;
            string result = "Ticks = " + elap;
            LB.Items.Add(result);

            watch = System.Diagnostics.Stopwatch.StartNew();
            long fact = Factorial(x);
            watch.Stop(); // 수행시간을 Ticks단위로 알려줌
            elap = watch.ElapsedTicks;
            result = "Ticks = " + elap;
            LB.Items.Add(result);

            LB.Items.Add("Recursive : " + rfact);
            LB.Items.Add("반복문 : " + fact);
        }

        private long Factorial(long x)
        {
            long f = 1;
            for (int i = 2; i <= x; i++)
                f *= i;
            return f;
        }

        private long rFactorial(long x)
        {
            if (x == 1)
                return 1;
            else
                return rFactorial(x - 1) * x;
        }
    }
}
