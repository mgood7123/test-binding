using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace m
{
    [XamlCompilation (XamlCompilationOptions.Compile)]
    public partial class BindingLabel : ContentView
    {
        public static readonly BindableProperty TestProperty =
  BindableProperty.Create("Test", typeof(string), typeof(BindingLabel), "Default",

      // get notified that this property has changed
      propertyChanged: OnTestChanged);

        private static void OnTestChanged(BindableObject bindable, object oldValue, object newValue)
        {
            // bindable is `this` object
            var this_ = (BindingLabel)bindable;

            // we can access `label` even if it is private
            this_.label.Text = (string) newValue;
        }

        public string Test
        {
            get => (string)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }

        private Label label;
        public BindingLabel()
        {
            InitializeComponent();
            label = new Label() { Text = Test };
            Content = label;
        }
    }
}
