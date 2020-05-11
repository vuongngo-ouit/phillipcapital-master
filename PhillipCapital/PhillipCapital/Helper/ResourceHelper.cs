using Xamarin.Forms;

namespace PhillipCapital.Helper
{
    public static class ResourceHelper
    {
        public static T Get<T>(string resourceName) where T : class
        {
            return Application.Current.Resources[resourceName] as T;
        }
        //Icon
        public static string WhiteStarIcon => Get<string>("WhiteStar");
        public static string BlueStarIcon => Get<string>("BlueStar");
        public static string WhiteDollarIcon => Get<string>("WhiteDollar");
        public static string BlueDollarIcon => Get<string>("BlueDollar");
        public static string WhiteHeartIcon => Get<string>("WhiteHeart");
        public static string BlueHeartIcon => Get<string>("BlueHeart");
        public static string RedHeartIcon => Get<string>("RedHeart");
        public static string BlackHeartIcon => Get<string>("BlackHeart");
        //Color
        public static string ColorWhite => Get<string>("WhiteColor");
        public static string ColorMainBlue => Get<string>("MainBlueColor");
        public static string ColorLightBlue => Get<string>("LightBlueColor");
        public static string ColorTransparent => Get<string>("TransparentColor");
        public static string ColorGrey => Get<string>("GreyColor");

    }

}
