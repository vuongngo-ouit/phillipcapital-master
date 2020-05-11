using Android.Content;
using PhillipCapital.Droid.Custom;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(DatePicker), typeof(BorderLessDatePickerRenderer))]

namespace PhillipCapital.Droid.Custom
{
    public class BorderLessDatePickerRenderer : DatePickerRenderer
    {
        public BorderLessDatePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }
        }
    }
}