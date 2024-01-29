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

namespace WpfApp2
{

    public partial class MainWindow : Window
    {
        Random random = new Random();
        Button[] buttons;
        public MainWindow()
        {
            InitializeComponent();
            buttons = new Button[9] { _1, _2, _3, _4, _5, _6, _7, _8, _9 };
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {

            (sender as Button).Content = "X";
            (sender as Button).IsEnabled = false;

            List<Button> availableButtons = new List<Button>();
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    availableButtons.Add(button);
            }

            if (availableButtons.Count > 0)
            {
                int knopka = random.Next(0, availableButtons.Count);
                availableButtons[knopka].Content = "O";
                availableButtons[knopka].IsEnabled = false;
            }

            if (CheckForWinX())
            {
                MessageBox.Show("Победил X");
                Application.Current.Shutdown();
            }
            else if (CheckForWinO())
            {
                MessageBox.Show("Победил O");
                Application.Current.Shutdown();
            }
            else if (CheckForTie())
            {
                MessageBox.Show("Ничья!");
                Application.Current.Shutdown();
            }


        }

        private bool CheckForTie()
        {
            foreach (Button button in buttons)
            {
                if (button.IsEnabled)
                    return false;
            }
            return true;
        }

        private bool CheckForWinO()
        {
            if (buttons[0].Content == buttons[1].Content && buttons[1].Content == buttons[2].Content && buttons[0].Content.ToString() == "O")
                return true;
            if (buttons[3].Content == buttons[4].Content && buttons[4].Content == buttons[5].Content && buttons[3].Content.ToString() == "O")
                return true;
            if (buttons[6].Content == buttons[7].Content && buttons[7].Content == buttons[8].Content && buttons[6].Content.ToString() == "O")
                return true;
            if (buttons[0].Content == buttons[3].Content && buttons[3].Content == buttons[6].Content && buttons[0].Content.ToString() == "O")
                return true;
            if (buttons[1].Content == buttons[4].Content && buttons[4].Content == buttons[7].Content && buttons[1].Content.ToString() == "O")
                return true;
            if (buttons[2].Content == buttons[5].Content && buttons[5].Content == buttons[8].Content && buttons[2].Content.ToString() == "O")
                return true;
            if (buttons[0].Content == buttons[4].Content && buttons[4].Content == buttons[8].Content && buttons[0].Content.ToString() == "O")
                return true;
            if (buttons[2].Content == buttons[4].Content && buttons[4].Content == buttons[6].Content && buttons[2].Content.ToString() == "O")
                return true;
            return false;
        }

        private bool CheckForWinX()
        {
            
            if (buttons[0].Content == buttons[1].Content && buttons[1].Content == buttons[2].Content && buttons[0].Content.ToString() == "X")
                return true;
            if (buttons[3].Content == buttons[4].Content && buttons[4].Content == buttons[5].Content && buttons[3].Content.ToString() == "X")
                return true;
            if (buttons[6].Content == buttons[7].Content && buttons[7].Content == buttons[8].Content && buttons[6].Content.ToString() == "X")
                return true;
            if (buttons[0].Content == buttons[3].Content && buttons[3].Content == buttons[6].Content && buttons[0].Content.ToString() == "X")
                return true;
            if (buttons[1].Content == buttons[4].Content && buttons[4].Content == buttons[7].Content && buttons[1].Content.ToString() == "X")
                return true;
            if (buttons[2].Content == buttons[5].Content && buttons[5].Content == buttons[8].Content && buttons[2].Content.ToString() == "X")
                return true;     
            if (buttons[0].Content == buttons[4].Content && buttons[4].Content == buttons[8].Content && buttons[0].Content.ToString() == "X")
                return true;
            if (buttons[2].Content == buttons[4].Content && buttons[4].Content == buttons[6].Content && buttons[2].Content.ToString() == "X")
                return true;

            return false;
        }

    }
}
