using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("H3B.Chat")]
[assembly: ExportEffect(typeof(H3B.Chat.iOS.CustomEffects.RemoveEntryBorderEffect), nameof(H3B.Chat.iOS.CustomEffects.RemoveEntryBorderEffect))]
namespace H3B.Chat.iOS.CustomEffects
{
    // Just a placeholder class as iOS doesn't have underlines on their entries.
    public class RemoveEntryBorderEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
        }

        protected override void OnDetached()
        {
        }
    }
}