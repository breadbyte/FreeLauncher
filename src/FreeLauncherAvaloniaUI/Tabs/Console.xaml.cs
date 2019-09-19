using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FreeLauncherAvaloniaUI.Tabs
{
    public class Console : UserControl
    {
        public Console()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
