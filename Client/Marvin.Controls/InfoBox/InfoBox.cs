﻿using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using C4I;
using Color = System.Drawing.Color;
using ColorExtensions = C4I.ColorExtensions;

namespace Marvin.Controls
{
    public class InfoBox : Control
    {
        static InfoBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(InfoBox), new FrameworkPropertyMetadata(typeof(InfoBox)));
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text", typeof (string), typeof (InfoBox), new PropertyMetadata(default(string)));

        public string Text
        {
            get { return (string) GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty BaseBrushProperty = DependencyProperty.Register(
            "BaseBrush", typeof(SolidColorBrush), typeof(InfoBox), new PropertyMetadata(default(SolidColorBrush), BrushChanged));

        public SolidColorBrush BaseBrush
        {
            get { return (SolidColorBrush) GetValue(BaseBrushProperty); }
            set { SetValue(BaseBrushProperty, value); }
        }

        private static void BrushChanged(DependencyObject d, DependencyPropertyChangedEventArgs args)
        {
            var control = (InfoBox)d;
            var newBrsuh = (SolidColorBrush)args.NewValue;

            control.SetBrush(newBrsuh);
        }

        private void SetBrush(SolidColorBrush brush)
        {
            var color = Color.FromArgb(brush.Color.A, brush.Color.R, brush.Color.G, brush.Color.B);
            var bgColor = color.Lerp(Color.White, 0.93f);
            var borderColor = color.Lerp(Color.Black, 0.2f);

            Background = new SolidColorBrush(System.Windows.Media.Color.FromArgb(bgColor.A, bgColor.R, bgColor.G, bgColor.B));
            BorderBrush = new SolidColorBrush(System.Windows.Media.Color.FromArgb(borderColor.A, borderColor.R, borderColor.G, borderColor.B));
        }
    }
}