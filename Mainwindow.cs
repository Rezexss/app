using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System;

namespace YourNamespace
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        protected override void OnOpened(EventArgs e)
        {
            base.OnOpened(e);
            // Ваш код, который будет выполнен при открытии окна
        }
    }
}
