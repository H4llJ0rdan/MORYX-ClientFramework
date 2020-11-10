// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Moryx.WpfToolkit
{
    /// <inheritdoc />
    /// <summary>
    /// Converts a boolean value to GridLength instance
    /// </summary>
    public class BooleanToGridRowHeightConverter : IValueConverter
    {
        /// <summary>
        /// Converts a boolean value to GridLength instance
        /// </summary>
        /// <param name="value">Boolean value</param>
        /// <param name="targetType">Not used</param>
        /// <param name="parameter">Not used</param>
        /// <param name="culture">Not used</param>
        /// <returns>Returns a starred <see cref="GridLength"/> if value is true otherwise a zero length <see cref="GridLength"/></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return this.AsBool(value) ? new GridLength(1, GridUnitType.Star) : new GridLength(0);
        }

        /// <inheritdoc />
        /// <summary>
        /// Not supported
        /// </summary>
        /// <exception cref="T:System.NotImplementedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
