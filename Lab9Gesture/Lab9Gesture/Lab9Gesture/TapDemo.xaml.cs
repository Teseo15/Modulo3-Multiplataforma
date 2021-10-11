using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab9Gesture
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TapDemo : ContentPage
    {
        int tapCount;
        readonly Label label;
        public TapDemo()
        {
            InitializeComponent();
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs args)
        {
            tapCount++;
            var imageSender = (Image)sender;
            // watch the monkey go from color to black&white!
            if (tapCount % 2 == 0)
            {
                imageSender.Source = "lionblue.jpg";
            }
            else
            {
                imageSender.Source = "lionfenix.jpg";
            }
        }
    }

}