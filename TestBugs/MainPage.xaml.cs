using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestBugs
{
    public partial class MainPage : ContentPage
    {
        // REPLACE "TestBugs" with your project's assembly name.
        public const string AssemblyName = "TestBugs";


        public enum Orientation
        {
            One, Two, Three, Four
        }

        const int NOrientations = 4;


        public MainPage()
        {
            // Assuming stored locally in files or resources.
            // If need server queries, recommend not doing this in constructor.
            LoadOurImages();

            InitializeComponent();
            // In this simple example, the binding sources are in the page itself.
            BindingContext = this;
        }


        protected override void OnAppearing()
        {
            base.OnAppearing();

            BackgroundTestLoop();
        }

        static Random Rand = new Random();

        private void BackgroundTestLoop()
        {
            Task.Run(async () =>
            {
                const int NTimes = 20;
                for (int i = 0; i < NTimes; i++)
                {
                    await Task.Delay(3000);

                    Orientation nextOrient = (Orientation)Rand.Next(NOrientations);
                    // Only affect UI from main thread.
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        Orient = nextOrient;
                    });
                }
            });
        }

        public Orientation Orient {
            get => _orient;
            set
            {
                _orient = value;
                // When Orient changes, that affects the values of these properties.
                OnPropertyChanged(nameof(Source1A));
                OnPropertyChanged(nameof(Source1B));
                OnPropertyChanged(nameof(Source2A));
                OnPropertyChanged(nameof(Source2B));
            }
        }
        private Orientation _orient = Orientation.One;

        public ImageSource Source1A => Sources[Indexes1A[(int)Orient]];
        public ImageSource Source1B => Sources[Indexes1B[(int)Orient]];
        public ImageSource Source2A => Sources[Indexes2A[(int)Orient]];
        public ImageSource Source2B => Sources[Indexes2B[(int)Orient]];


        List<string> ResourcePaths = new List<string> {
            "apple_x64.png", "boat_on_water_x64.png", "pine_tree_x64.png", "unicorn_head_pink_x64.png"};

        List<ImageSource> Sources = new List<ImageSource>();

        // Change these as needed.
        List<int> Indexes1A = new List<int> { 0, 1, 2, 3 };
        List<int> Indexes1B = new List<int> { 1, 2, 3, 0 };
        List<int> Indexes2A = new List<int> { 2, 3, 0, 1 };
        List<int> Indexes2B = new List<int> { 3, 0, 1, 2 };



        private void LoadOurImages()
        {
            foreach (var path in ResourcePaths)
                Sources.Add(CreateOurSource(path));
        }

        private ImageSource CreateOurSource(string resourcePath)
        {
            // For embedded resources stored in project folder "Media".
            var resourceID = $"{AssemblyName}.Media.{resourcePath}";
            // Our media is in the cross-platform assembly. Same is this page.
            Assembly assembly = this.GetType().GetTypeInfo().Assembly;
            ImageSource source = ImageSource.FromResource(resourceID, assembly);
            return source;
        }
    }
}
