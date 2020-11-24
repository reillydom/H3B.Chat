using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("H3B.Chat")]
[assembly: ExportEffect(typeof(H3B.Chat.Droid.CustomEffects.RemoveEntryBorderEffect), nameof(H3B.Chat.Droid.CustomEffects.RemoveEntryBorderEffect))]
namespace H3B.Chat.Droid.CustomEffects
{
    public class RemoveEntryBorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {

            Control?.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

        protected override void OnDetached()
        {
        }
    }
}