using System;
using System.Windows;
using System.Windows.Controls;
namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] check = { "X", "O" };
        int value = 1;
        string xOrO = "X";
        string voi = " ";
        Random z = new();
        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            (sender as Button).IsEnabled = false;
            (sender as Button).Content = xOrO;
            if (xOrO == "X")
            {
                xOrO = "O";
                if (value == 1){
                    value++;
                }
                else if (value == 2){
                    value--;
                }
                i++;
                pla.Text = Convert.ToString(value);
            }
            else if (xOrO == "O")
            {
                xOrO = "X";
                if (value == 1) {
                    value++;

                }
                else if (value == 2) {
                    value--;
                }
                pla.Text = Convert.ToString(value);
                i++;
            }
            int a = z.Next(0, 8);

            if (i < 9)
            {
                while ((buttons[a].Content == check[0] || buttons[a].Content == check[1]))
                {
                    a = z.Next(0, 8);
                }
                NewMethod(buttons);
                buttons[a].Content = xOrO;
                buttons[a].IsEnabled = false;
                NewMethod1();
            }
            NewMethod(buttons);
        }

        private void NewMethod1()
        {
            if (xOrO == "X")
            {
                xOrO = "O";
                i++;
            }
            else if (xOrO == "O")
            {

                xOrO = "X";
                i++;
            }
        }

        private void NewMethod(Button[] buttons)
        {
            for (int a = 0; a < 2; a++)
            {
            if ((check[a] == Convert.ToString(buttons[0].Content) && check[a] == Convert.ToString(buttons[1].Content) && check[a] == Convert.ToString(buttons[2].Content)) || (check[a] == Convert.ToString(buttons[3].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[5].Content)) || (check[a] == Convert.ToString(buttons[6].Content) && check[a] == Convert.ToString(buttons[7].Content) && check[a] == Convert.ToString(buttons[8].Content)) || (check[a] == Convert.ToString(buttons[0].Content) && check[a] == Convert.ToString(buttons[3].Content) && check[a] == Convert.ToString(buttons[6].Content)) || (check[a] == Convert.ToString(buttons[1].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[7].Content)) || (check[a] == Convert.ToString(buttons[2].Content) && check[a] == Convert.ToString(buttons[5].Content) && check[a] == Convert.ToString(buttons[8].Content)) || (check[a] == Convert.ToString(buttons[0].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[8].Content)) || (check[a] == Convert.ToString(buttons[2].Content) && check[a] == Convert.ToString(buttons[4].Content) && check[a] == Convert.ToString(buttons[6].Content)))
            {
                foreach (Button button in buttons)
                {
                    button.IsEnabled = false;
                }

                win();
            }
            }
            if(i==9)
            {
                winner.Text = "Победа за: ";
                num.Text = "Ничья";
            
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button[] buttons = new Button[] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };
            foreach (Button button in buttons)
            {
                i = 0;
                button.Content = voi;
                button.IsEnabled = true;
                winner.Text = "Победа за: ";
                num.Text = voi;
                NewMethod1();
            }
        }
        public void win()
        {
            winner.Text = "Победа за: ";
            num.Text = Convert.ToString(value);
        }
        private void raian_Click(object sender, RoutedEventArgs e)
        {
            raion1.Text = "Райан Гослинг говорит: Люблю Софию Алексеевну!";
        }
    }
}
