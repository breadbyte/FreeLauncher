using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FreeLauncherAvaloniaUI.Tabs
{
    public class News : UserControl
    {
        public News()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
