using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace _1._2._05._01_Saver
{
    public partial class MainWindow : Window
    {
        int page = 0;
        public MainWindow()
        {
            InitializeComponent();
            Program.Start();
            Action2();
        }

        public void Action1(List<Person> dataList)
        {



            int left = 5, top = 15, right = 0, bottom = 0;
            int i = 0;
            foreach (Person person in dataList)
            {
                if (person is null) { continue; }
                i++;
                person.GetPerson(out string name, out string surName, out int age, out string prof, out int number);
                Thickness thickness = new Thickness(left, top * i * 3, right, bottom);
                TextBlock text1 = new TextBlock() { Text = $"{number}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                //Button button = new Button() {Content = $"Кнопка {i}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                grid.Children.Add(text1);
                thickness.Left = 75;
                TextBlock text2 = new TextBlock() { Text = name, Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                //Button button = new Button() {Content = $"Кнопка {i}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                grid.Children.Add(text2);

                thickness.Left = 250;
                TextBlock text3 = new TextBlock() { Text = surName, Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                //Button button = new Button() {Content = $"Кнопка {i}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                grid.Children.Add(text3);

                thickness.Left = 450;
                TextBlock text4 = new TextBlock() { Text = $"{age}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                //Button button = new Button() {Content = $"Кнопка {i}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                grid.Children.Add(text4);

                thickness.Left = 550;
                TextBlock text5 = new TextBlock() { Text = prof, Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                //Button button = new Button() {Content = $"Кнопка {i}", Width = 70, Height = 30, HorizontalAlignment = HorizontalAlignment.Left, VerticalAlignment = VerticalAlignment.Top, Margin = thickness };
                grid.Children.Add(text5);
            }


        }

        public void Action2()
        {
            List<Person> dataList = new List<Person>(5);

            for (int i = 0; i < 5; i++)
            {
                if (((page * 5) + i) >= Program.data.Count) { continue; }
                dataList.Add(Program.data[(page * 5) + i]);
            }

            Action1(dataList);





        }


        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            PagePlus();
        }

        public void PagePlus()
        {
            if (((page + 1) * 5 < Program.data.Count))
            {
                page++;
                grid.Children.Clear();
                Action2();
            }
        }

        public void PageMinus()
        {
            if (page > 0)
            {
                page--;
                grid.Children.Clear();
                Action2();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageMinus();
        }

        private void Window_MouseWheel(object sender, System.Windows.Input.MouseWheelEventArgs e)
        {
            PagePlus();
        }

        

       
    }   
}