//Вариант 18 -> 8
//Atmoslayer start code
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

namespace Zadanie3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }

        private void Tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            int symbols = 0;
            int words = 0;

            int space = 0;
            
            if (Tb1 != null)
            {
                string result = "";
                foreach(var c in Tb1.Text)
                {
                    if (Char.IsLetter(c))
                    {
                       symbols ++;
                       space = 1;
                    }
                    if (Char.IsWhiteSpace(c) || Char.IsPunctuation(c))
                    {
                        switch(space)
                        {
                            case 1:
                                words++;
                                space=2;
                                break;
                            case 2:
                                break;

                        }
                        Lb1.Content = words;
                        Lb2.Content = symbols;
                    }
                 
                }

            }
        }
    }
}
//Atmoslayer end code