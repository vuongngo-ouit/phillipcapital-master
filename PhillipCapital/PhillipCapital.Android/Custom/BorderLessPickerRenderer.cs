using Android.Content;
using PhillipCapital.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Picker), typeof(BorderLessPickerRenderer))]

namespace PhillipCapital.Droid.Custom
{
    public class BorderLessPickerRenderer : PickerRenderer
    {
        public BorderLessPickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}