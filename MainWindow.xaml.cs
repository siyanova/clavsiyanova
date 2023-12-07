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

namespace clavsiyanova
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool flag=false;
        private MyButtons[] buttons = new MyButtons[47];
        private Border[] borders = new Border[59]; 
        public MainWindow()
        {
            InitializeComponent();
           

            buttons[0] = new MyButtons("~", "`", tilda);
            buttons[1] = new MyButtons("!", "1", one);
            buttons[2] = new MyButtons("@", "2", two);
            buttons[3] = new MyButtons("#", "3", three);
            buttons[4] = new MyButtons("$", "4", four);
            buttons[5] = new MyButtons("%", "5", five);
            buttons[6] = new MyButtons("&", "6", six);
            buttons[7] = new MyButtons("^", "7", seven);
            buttons[8] = new MyButtons("*", "8", eight);
            buttons[9] = new MyButtons("(", "9", nine);
            buttons[10] = new MyButtons(")", "0", zero);
            buttons[11] = new MyButtons("_", "-", dash);
            buttons[12] = new MyButtons("+", "=", equal);
            buttons[13] = new MyButtons("Q", "q", textq);
            buttons[14] = new MyButtons("W", "w", textw);
            buttons[15] = new MyButtons("E", "e", texte);
            buttons[16] = new MyButtons("R","r",textr);
            buttons[17] = new MyButtons("T", "t", textt);
            buttons[18] = new MyButtons("Y", "y", texty);
            buttons[19] = new MyButtons("U", "u", textu);
            buttons[20] = new MyButtons("I", "i", texti);
            buttons[21] = new MyButtons("O", "o", texto);
            buttons[22] = new MyButtons("P", "p", textp);
            buttons[23] = new MyButtons("{", "[", bracket1);
            buttons[24] = new MyButtons("}", "]", bracket2);
            buttons[25] = new MyButtons("|", "\\", backslash);
            buttons[26] = new MyButtons("A", "a", texta);
            buttons[27] = new MyButtons("S", "s", texts);
            buttons[28] = new MyButtons("D", "d", textd);
            buttons[29] = new MyButtons("F", "f", textf);
            buttons[30] = new MyButtons("G", "g", textg);
            buttons[31] = new MyButtons("H", "h", texth);
            buttons[32] = new MyButtons("J", "j", textj);
            buttons[33] = new MyButtons("K", "k", textk);
            buttons[34] = new MyButtons("L", "l", textl);
            buttons[35] = new MyButtons(":", ";", colon);
            buttons[36] = new MyButtons("\"", "'", apostrophe);
            buttons[37] = new MyButtons("Z", "z", textz);
            buttons[38] = new MyButtons("X", "x", textx);
            buttons[39] = new MyButtons("C", "c", textc);
            buttons[40] = new MyButtons("V", "v", textv);
            buttons[41] = new MyButtons("B", "b", textb);
            buttons[42] = new MyButtons("N", "n", textn);
            buttons[43] = new MyButtons("M", "m", textm);
            buttons[44] = new MyButtons("<", ",", comma);
            buttons[45] = new MyButtons(">", ".", point);
            buttons[46] = new MyButtons("?", "/", slash);
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Difficult.Text = Slider.Value.ToString();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;
            Stop.IsEnabled = true;

            output.Focusable = true;
            output.Focus();

            Random random = new Random();

            string line = "";
            for (int i = 0; i < Slider.Value; i++)
            {
                int a = random.Next(32, 126);
                char b = Convert.ToChar(a);
                line += b;

            }
            input.Text = line;
           
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = true;
            Stop.IsEnabled = false;
        }
       

        private void Start_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.Key == Key.Tab) 
            {
                BorderTab.Background = new SolidColorBrush(Colors.White);
            }
           
            if (e.Key == Key.CapsLock)
            {  
                    if (flag == false)
                {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].upValue;
                    }
                        flag = true;
                    }
                    else
                    {
                    for (int i = 0; i < buttons.Length; i++)
                    {
                        buttons[i].textBlock.Text = buttons[i].downValue;
                    }
                        flag = false;
                    }
                
                BorderCapsLock.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.LeftShift)
            {
                BorderLeftShift.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.LeftCtrl)
            {
                BorderLeftCtrl.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.LWin)
            {
                BorderLWin.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.LeftAlt)
            {
                BorderLeftAlt.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.Space)
            {
                BorderSpace.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.RightAlt)
            {
                BorderRightAlt.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.RWin)
            {
                BorderRWin.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.RightCtrl)
            {
                BorderRightCtrl.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.RightShift)
            {
                BorderRightShift.Background = new SolidColorBrush(Colors.White);
            }
            else if (e.Key == Key.Enter)
            {
                BorderEnter.Background = new SolidColorBrush(Colors.White);
            }

        }

        private void Start_KeyUp(object sender, KeyEventArgs e)
        {
            output.Text += e.Key;
            if (e.Key == Key.Tab)
            {
                BorderTab.Background = new SolidColorBrush(Colors.LightGray);
            }else if (e.Key == Key.CapsLock)
            {
                BorderCapsLock.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (e.Key == Key.LeftShift)
            {
                BorderLeftShift.Background = new SolidColorBrush(Colors.LightGray);
            }
            else if (e.Key == Key.LeftCtrl)
            {
                BorderLeftCtrl.Background = new SolidColorBrush(Colors.LightGray);
            }
        }
    }
}
