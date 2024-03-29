﻿using System.Collections.Generic;

namespace EU4_PCP
{
    public static class Names
    {
        public static readonly Dictionary<string, string> GlobalNames = new(){
            { "GamePathFilter", "EU4 Executable|eu4.exe" },
            { "GamePathPlaceholder", "[not set]" },
            { "ModPathFilter", "mod file|*.mod" },
            { "ModPathPlaceholder", "[not set]" },
            { "ProvinceNamesDefault", "0" },
            { "AutoLoadDefault", "1" },
            { "ShowAllProvincesDefault", "0" },
            { "CheckDupliDefault", "0" },
            { "UpdateMaxProvDefault", "1" },
            { "IterateMaxProvDefault", "0" },
            { "ShowIllegalProvDefault", "0" },
            { "IgnoreIllegalDefault", "0" },
            { "InCDefault", "1" },
            { "DateFormatDefault", "0" },
            { "WorkDirsDefault", "1" },
            { "ProvTableDefault", "0" },
            { "ColorPickerDefault", "0" },
            { "PersonalizationDefault", "0" },
            { "AboutDefault", "1" },
            { "OverrideBooksDefault", "1" },
            { "MaxProvPositive", "Amount of provinces is within the limit." },
            { "MaxProvNegative", "Amount of provinces exceeds the limit." },
            { "ModProvNegative", "The game has more provinces, so name conflicts may occur." }
        };
    }
}
