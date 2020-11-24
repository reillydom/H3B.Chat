using System.Linq;
using Xamarin.Forms;

namespace H3B.Chat.Behaviors
{
    public static class LineColorBehavior
    {
        public static readonly BindableProperty ShouldApplyLineColorProperty =
            BindableProperty.CreateAttached("ShouldApplyLineColor", typeof(bool), typeof(LineColorBehavior), false,
                propertyChanged: OnApplyLineColorChanged);



        public static readonly BindableProperty LineColorProperty =
            BindableProperty.CreateAttached("LineColor", typeof(Color), typeof(LineColorBehavior), Color.Default);

        public static bool GetShouldApplyLineColor(BindableObject view)
        {
            return (bool)view.GetValue(ShouldApplyLineColorProperty);
        }

        public static void SetShouldApplyLineColor(BindableObject view, bool value)
        {
            view.SetValue(ShouldApplyLineColorProperty, value);
        }

        public static Color GetLineColor(BindableObject view)
        {
            return (Color)view.GetValue(LineColorProperty);
        }

        public static void SetLineColor(BindableObject view, Color value)
        {
            view.SetValue(LineColorProperty, value);
        }

        private static void OnApplyLineColorChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (!(bindable is View view))
            {
                return;
            }

            bool hasLine = (bool)newValue;

            if (hasLine)
            {
                view.Effects.Add(new CustomEffects.EntryLineColorEffect());
            }
            else
            {
                var entryLineColorEffectToRemove = view.Effects.FirstOrDefault(e => e is CustomEffects.EntryLineColorEffect);
                if (entryLineColorEffectToRemove != null)
                {
                    view.Effects.Remove(entryLineColorEffectToRemove);
                }
            }
        }
    }
}
