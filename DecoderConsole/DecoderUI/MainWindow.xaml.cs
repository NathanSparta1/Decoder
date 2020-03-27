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
using DecoderConsole;

namespace DecoderUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string CurrentCode;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
        }

        void Initialise()
        {
            // Create a list of all available codes then subscribe codes to them
            List<string> Codes = new List<string>();
            Codes.Add("Roman Numeral");
            Codes.Add("Skip Code");
            Codes.Add("First Letter");
            CodeOptionBox.ItemsSource = Codes;
        }
       
        private void ChangeCode(object sender, SelectionChangedEventArgs e)
        {
            CurrentCode = (string)CodeOptionBox.SelectedItem;
            //update the code label when a different code is selected
            if(CurrentCode != null)
            {
                CodeLabel.Content = CodeOptionBox.SelectedItem;
            }
            
        }

        private void DecodeButton(object sender, RoutedEventArgs e)
        {
            // function from Decoder Console project
            // set output box as the return value of the function
            Output.Content = Decrypt.retValue((string)CodeLabel.Content, InputTb.Text);
        }
    }
}
