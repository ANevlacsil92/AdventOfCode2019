using AdventOfConsole.Days;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace AdventOfConsole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static TextBox input;
        public static TextBox log;
        public static TextBox answerOne;
        public static TextBox answerTwo;

        public MainWindow()
        {
            InitializeComponent();
            input = tbInput;
            log = tbLog;
            answerOne = tbAnswerOne;
            answerTwo = tbAnswerTwo;
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = Stopwatch.StartNew();
            TimeSpan offset;
                                     
            Day3.christmassySolvePuzzleOne();
            offset = sw.Elapsed;

            Day3.christmassySolvePuzzleTwo();
            sw.Stop();

            tbAnswerElapsedOne.Text = offset.ToString(@"mm\:ss\:fff");
            tbAnswerElapsedTwo.Text = (sw.Elapsed - offset).ToString(@"mm\:ss\:fff");
            tbAnswerElapsedTotal.Text = sw.Elapsed.ToString(@"mm\:ss\:fff");
        }
    }
}
