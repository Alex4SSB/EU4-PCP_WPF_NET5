﻿using System;
using System.Windows.Controls.Primitives;

namespace EU4_PCP.Converters
{
    public static class EnumToLong
    {
        public static long GetIndex(this ToggleButton item) => GetIndex(item.Tag.ToString().Split('|'));

        public static long GetIndex(params string[] property) => GetIndex(property[0], property[1]);

        public static long GetIndex(string enumName, string enumValue)
        {
            Type type = enumName.ToEnum();
            return Array.IndexOf(Enum.GetValues(type), Enum.Parse(type, enumValue));
        }
    }
}
