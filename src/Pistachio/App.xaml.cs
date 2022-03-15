// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Pistachio
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public partial class App : Application
    {


        private Window _MainWindow;

        /// <summary>
        /// This DI container manages project's dependencies
        /// </summary>
        public ServiceProvider Container
            { get; private set; }
                  
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeComponent();

            // Enable the sound queues across the app
            ElementSoundPlayer.State = ElementSoundPlayerState.On;
            ElementSoundPlayer.SpatialAudioMode = ElementSpatialAudioMode.On;
                    }

        /// <summary>
        /// Initializes the DI container
        /// </summary>
        /// <returns> An instance implementing ServiceProvider.</returns>

        public static ServiceProvider RegisterServices()
        {
            ServiceCollection services = new ();
            services.AddTransient<MainViewModel>();
            return services.BuildServiceProvider();
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="args">Details about the launch request and process.</param>
        protected override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
        {
            Container = RegisterServices();
            _MainWindow = new MainWindow();
            _MainWindow.Activate();
        }

    }
}
