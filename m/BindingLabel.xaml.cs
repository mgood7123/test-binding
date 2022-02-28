using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace m
{
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class BindingLabel : ContentView
    {
        public static readonly BindableProperty TestProperty =
  BindableProperty.Create("Test", typeof(string), typeof(BindingLabel), "Default");

        public string Test
        {
            get { return (string)GetValue(TestProperty); }
            set {
                SetValue(TestProperty, value);
                label.Text = value;
            }
        }

        Label label;
        public BindingLabel()
        {
            InitializeComponent();
            label = new Label() { Text = Test };
            Content = label;
        }
    }
}
