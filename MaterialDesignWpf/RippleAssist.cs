using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace MaterialDesignWpf
{
    public static class RippleAssist
    {

        #region Feedback

        public static readonly DependencyProperty FeedbackProperty = DependencyProperty.RegisterAttached(
            "Feedback", typeof(Brush), typeof(RippleAssist), new FrameworkPropertyMetadata(default(Brush), FrameworkPropertyMetadataOptions.Inherits | FrameworkPropertyMetadataOptions.AffectsRender));

        public static void SetFeedback(DependencyObject element, Brush value)
        {
            element.SetValue(FeedbackProperty, value);
        }

        public static Brush GetFeedback(DependencyObject element)
        {
            return (Brush)element.GetValue(FeedbackProperty);
        }

        #endregion
    }
}
