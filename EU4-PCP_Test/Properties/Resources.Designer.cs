﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EU4_PCP_Test.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("EU4_PCP_Test.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to government = monarchy
        ///add_government_reform = feudalism_reform
        ///government_rank = 1
        ///technology_group = western
        ///primary_culture = lombard
        ///religion = catholic
        ///capital = 1773	# Mystras
        ///
        ///# ADDED FOR TESTING #
        ///900.1.1 = { primary_culture = lombard religion = catholic }
        ///
        ///# 930.1.1 = { primary_culture = omani_culture religion = sunni }
        ///
        ///#940.1.1 = {
        ///#	primary_culture = omani_culture
        ///#	religion = sunni
        ///#}
        ///
        ///950.1.1 = {
        ///#	primary_culture = omani_culture
        ///	religion = sunni
        ///}
        ///
        ///# Principality of Ach [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string ACH {
            get {
                return ResourceManager.GetString("ACH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///bookmark =
        ///{
        ///	name = &quot;AMERICAN_CIVIL_WAR_NAME&quot;
        ///	desc = &quot;AMERICAN_CIVIL_WAR_DESC&quot;
        ///	date = 1861.7.1
        ///	
        ///	country = USA
        ///	country = CSA
        ///}
        ///.
        /// </summary>
        internal static string american_civil_war {
            get {
                return ResourceManager.GetString("american_civil_war", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 233 = &quot;Kernow&quot; #Cornwall
        ///4373 = &quot;Dewnens&quot; #Devon
        ///4130 = &quot;Stradneth&quot; #Somerset
        ///4374 = &quot;Durotriges&quot; #Dorset
        ///234 = &quot;Belgae&quot; #Hampshire
        ///236 = &quot;Loundres&quot; #London
        ///237 = &quot;Rysoghen&quot; #Oxford
        ///4370 = &quot;Grantapons&quot; #Cambridge
        ///245 = &quot;Evrek&quot; #York
        ///373 = &quot;Dulynn&quot; #Dublin
        ///4369 = &quot;Ceredigion&quot; #Carmarthen.
        /// </summary>
        internal static string cornish {
            get {
                return ResourceManager.GetString("cornish", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # Do not change tags in here without changing every other reference to them.
        ///# If adding new groups or cultures, make sure they are unique.
        ///#
        ///# Union tags do not suffer from the &apos;same_culture_group&apos; tax penalty.
        ///# Primary tags are the first choice for rebel factions seeking cultural independence.
        ///#
        ///# graphical_culture = westerngfx
        ///# second_graphical_culture = muslimgfx (fallback if the first does not exist)
        ///
        ///germanic = {
        ///	graphical_culture = westerngfx
        ///
        ///	male_names = { Gunther Rolf }
        ///	
        ///	pommer [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string cultures {
            get {
                return ResourceManager.GetString("cultures", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to province;red;green;blue;x;x
        ///2;0;36;128;Östergötland;x
        ///1609;104;252;252;Southern Atlantic #4;x
        ///2905;227;31;59;Rio Das Mortes;x
        ///2941;12;149;188;;x
        ///2963;85;232;161;
        ///3130;207;110;79;Unused117
        ///3217;219;32;27;UnusedLand27
        ///3959;100;13;159;RNW
        ///.
        /// </summary>
        internal static string definition {
            get {
                return ResourceManager.GetString("definition", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to province;red;green;blue;x;x
        ///-2;0;36;128;Östergötland;x
        ///1609;600;252;252;Southern Atlantic #4;x
        ///2905;227;-31;59;Rio Das Mortes;x
        ///2941;12;q;188;Choquechaca (Caracaras);x
        ///.
        /// </summary>
        internal static string definition_negative {
            get {
                return ResourceManager.GetString("definition_negative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to #151 - Constantinople
        ///
        ///owner = ROM
        ///controller = ROM
        ///culture = greek
        ///religion = hellenism
        ///capital = &quot;Byzantium&quot;
        ///trade_goods = glass
        ///hre = no
        ///discovered_by = ottoman
        ///discovered_by = nomad_group
        ///discovered_by = western_nomad_group
        ///discovered_by = middle_eastern
        ///discovered_by = muslim
        ///discovered_by = roman_group
        ///discovered_by = eastern
        ///discovered_by = barbarian
        ///discovered_by = western
        ///base_tax = 8
        ///base_production = 8
        ///base_manpower = 4
        ///is_city = yes
        ///fort_15th = yes 
        ///add_core = ROM
        ///center_ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Prov_151 {
            get {
                return ResourceManager.GetString("Prov_151", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to bookmark =
        ///{
        ///	name = &quot;RISE_OF_THE_OTTOMANS&quot;
        ///	desc = &quot;RISE_OF_THE_OTTOMANS_DESC&quot;
        ///	date = 1444.11.11
        ///	
        ///	center = 112
        ///	default = yes
        ///	
        ///	country = TUR
        ///	country = CAS
        ///	country = POR	
        ///	country = FRA
        ///	country = ENG
        ///	country = HAB
        ///	country = BRA	
        ///	country = SWE
        ///	country = MOS
        ///	country = BUR
        ///	country = POL
        ///	
        ///	easy_country = CAS
        ///	easy_country = POR
        ///	easy_country = TUR
        ///}.
        /// </summary>
        internal static string rise_of_the_ottomans {
            get {
                return ResourceManager.GetString("rise_of_the_ottomans", resourceCulture);
            }
        }
    }
}
