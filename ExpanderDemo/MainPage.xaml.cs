using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Toolkit.Uwp.UI.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExpanderDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void TestButton_OnClick(object sender, RoutedEventArgs e)
        {
            //generate 10 random school subjects
            var subjects = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                var subject = "Subject " + i;
                subjects.Add(subject);
            }

            //generate 200 random lessons
            var lessons = new List<string>();
            for (int i = 0; i < 250; i++)
            {
                var lesson = "Lesson " + i;
                lessons.Add(lesson);
            }


            foreach (var subject in subjects)
            {
                var expander = new Expander();
                expander.Header = subject;
                var listView = new ListView();
                listView.ItemsSource = lessons;

                expander.Content = listView;
                TestStackPanel.Children.Add(expander);
            }



        }
    }
}
