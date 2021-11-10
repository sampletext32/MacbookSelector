using System.Windows;
using System.Windows.Controls;

namespace MacbookSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _age;
        private int _salary;

        private bool _pcWork = true;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgeTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(AgeTextBox.Text, out _age))
            {
                MessageBox.Show("Failed to parse age");
            }

            if (ResultLabel is not null) ResultLabel.Content = "";
        }

        private void SalaryTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            if (!int.TryParse(SalaryTextBox.Text, out _salary))
            {
                MessageBox.Show("Failed to parse salary");
            }

            if (ResultLabel is not null) ResultLabel.Content = "";
        }

        private void PcWorkRadioButton_OnChecked(object sender, RoutedEventArgs e)
        {
            _pcWork = true;
            if (ResultLabel is not null) ResultLabel.Content = "";
        }

        private void PcNotWorkRadioButton_OnChecked(object sender, RoutedEventArgs e)
        {
            _pcWork             = false;
            if (ResultLabel is not null) ResultLabel.Content = "";
        }

        private void GetResultButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (_age == 0 || _salary == 0)
            {
                ResultLabel.Content = "Сначала заполните все поля";
                return;
            }
            if (_age >= 16 && _salary >= 60000 && _pcWork)
            {
                ResultLabel.Content = "Вам нужен Macbook";
            }
            else
            {
                ResultLabel.Content = "Вам НЕ нужен Macbook";
            }
        }
    }
}