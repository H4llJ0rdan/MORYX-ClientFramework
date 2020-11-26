// Copyright (c) 2020, Phoenix Contact GmbH & Co. KG
// Licensed under the Apache License, Version 2.0

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Moryx.Serialization;

namespace Moryx.Controls.Converter
{
    /// <summary>
    /// Converts an entry type to <see cref="Visibility"/>
    /// </summary>
    public class EntryTypeToDelButtonVisibilityConverter : IValueConverter
    {
        /// <inheritdoc />
        /// <summary>
        /// Converts value to <see cref="Visibility"/>
        /// </summary>
        /// <param name="value"><see cref="EntryViewModel"/> instance</param>
        /// <param name="targetType">Not used</param>
        /// <param name="parameter">Not used</param>
        /// <param name="culture">Not used</param>
        /// <returns>Returns <see cref="Visibility.Visible"/> if entry type is <see cref="EntryValueType.Collection"/> otherwise <see cref="Visibility.Collapsed"/> </returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var entry = value as EntryViewModel;
            if (entry == null)
                return Visibility.Collapsed;

            return entry.ValueType == EntryValueType.Collection && !entry.IsReadOnly
                ? Visibility.Visible
                : Visibility.Collapsed;
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
