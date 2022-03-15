// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

using WinRT;

namespace Pistachio
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {

        internal MainViewModel ViewModel { get; } = (Application.Current as App).Container.GetService<MainViewModel>();

        public MainWindow()
        {
            this.InitializeComponent();

        }

    }
}
