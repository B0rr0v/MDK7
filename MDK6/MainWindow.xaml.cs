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
//Использовать класс Triangle (треугольник) с полями-сторонами. Разработать операцию для определения возможности существование треугольника с заданными сторонами true/false.
//Разработать операции для увеличения/уменьшения сторон на 1.
namespace MDK6
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

        private void Очистка(object sender, RoutedEventArgs e)
        {
            A.Clear();
            B.Clear();
            C.Clear();
            ymA.Clear();
            ymB.Clear();
            ymC.Clear();
            yvA.Clear();
            yvB.Clear();
            yvC.Clear();
        }



        private void Уменьшение(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(A.Text, out int a);// проверка на числовой тип данных
            bool f2 = Int32.TryParse(B.Text, out int b);
            bool f3 = Int32.TryParse(C.Text, out int c);
            if (f1 && f2 && f3 && a > 0 && b > 0 && c > 0)
            {
                Triangle number = new Triangle(a, b, c);
                if (number)
                {
                    number--;
                    ymA.Text = Convert.ToString(number.A);
                    ymB.Text = Convert.ToString(number.B);
                    ymC.Text = Convert.ToString(number.C);
                }
                else MessageBox.Show("Ошибка,введите правильные стороны треугольника");
            }
            else MessageBox.Show("Ошибка, должны быть заполнены текстбоксы с правильными сторонами");

        }
        private void Увеличение(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(A.Text, out int a);// проверка на числовой тип данных
            bool f2 = Int32.TryParse(B.Text, out int b);
            bool f3 = Int32.TryParse(C.Text, out int c);
            if (f1 && f2 && f3 && a > 0 && b > 0 && c > 0)
            {

                Triangle number = new Triangle(a, b, c);
                if (number)
                {
                    number++;
                    yvA.Text = Convert.ToString(number.A);
                    yvB.Text = Convert.ToString(number.B);
                    yvC.Text = Convert.ToString(number.C);
                }
                else MessageBox.Show("Ошибка,введите правильные стороны треугольника");
            }
            else MessageBox.Show("Ошибка, должны быть заполнены текстбоксы с правильными  сторонами");

        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Агальцов Даниил ИСП-31 Практическая работа №7:Использовать класс Triangle (треугольник) с полями-сторонами. Создать производный класс Equilateral (равносторонний),имеющийполе площади.Определить метод вычисления площади.");
        }

        private void Расчет(object sender, RoutedEventArgs e)
        {
            bool f1 = Int32.TryParse(A.Text, out int a);// проверка на числовой тип данных
            bool f2 = Int32.TryParse(B.Text, out int b);
            bool f3 = Int32.TryParse(C.Text, out int c);
            if (f1 && f2 && f3 && a == b && b == c && c == a)
            {
                int side = a;
                Equilateral equilateral = new Equilateral(side);               
                double p= equilateral.Result();
                pl.Text = Convert.ToString(p);
            }
            else MessageBox.Show("Треугольник должен быть равносторонний");
        }
    }
}
