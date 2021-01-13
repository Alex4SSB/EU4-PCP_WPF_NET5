﻿using System;
namespace EU4_PCP_WPF
{
    public static class PCP_Paths
    {
		// DOCS FOLDERS
		public static readonly string UserFolder = $@"C:\Users\{Environment.UserName}";
		public static readonly string DocsFolder = @"\Documents\Paradox Interactive\Europa Universalis IV";
		public static readonly string DocsPath = $@"{UserFolder}{DocsFolder}";
		public static readonly string OneDrivePath = $@"{UserFolder}\OneDrive{DocsFolder}";
		public static readonly string ModPath = @"\mod";
		public static string ParadoxModPath = ""; // The folder that contains the .mod files
		public static string SteamModPath = ""; // Current Mod - parsed from the .mod file
		public static string SelectedDocsPath = ""; // OneDrive / Offline
		public static readonly string GameLogPath = @"\logs\game.log";

		// MAIN FOLDERS
		public static string GamePath = "";
		public static readonly string GameFile = @"\eu4.exe";
		public static readonly string DefinPath = @"\map\definition.csv";
		public static readonly string DefMapPath = @"\map\default.map";
		public static readonly string LocPath = @"\localisation";
		public static readonly string RepLocPath = @"\localisation\replace";
		public static readonly string HistProvPath = @"\history\provinces";
		public static readonly string HistCountryPath = @"\history\countries";
		public static readonly string CulturePath = @"\common\cultures";
		public static readonly string CultureFile = @"\00_cultures.txt";
		public static readonly string ProvNamesPath = @"\common\province_names";
		public static readonly string BookmarksPath = @"\common\bookmarks";
		public static readonly string DefinesPath = @"\common\defines";
		public static readonly string DefinesLuaPath = @"\common\defines.lua";

		// REPLACE FOLDERS
		public static readonly string CulturesRep = "common/cultures";
		public static readonly string BookmarksRep = "common/bookmarks";
		public static readonly string ProvNamesRep = "common/province_names";
		public static readonly string CountriesRep = "history/countries";
		public static readonly string ProvincesRep = "history/provinces";
		public static readonly string LocalisationRep = "localisation";
	}
}