﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HitagiBot.Localization {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("HitagiBot.Localization.Strings", typeof(Strings).Assembly);
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
        ///   Looks up a localized string similar to Oops, something went wrong ﾍ(;´o｀)ﾍ.
        /// </summary>
        internal static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Where would you like coordinates for (・∧‐)ゞ?.
        /// </summary>
        internal static string GeocodeDefault {
            get {
                return ResourceManager.GetString("GeocodeDefault", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Alright, I&apos;ve set your location to {0}..
        /// </summary>
        internal static string GeocodeLocationSet {
            get {
                return ResourceManager.GetString("GeocodeLocationSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to I couldn&apos;t find this location ┐(‘～`；)┌.
        /// </summary>
        internal static string GeocodeNotFound {
            get {
                return ResourceManager.GetString("GeocodeNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;b&gt;{0}\nLatitude:&lt;/b&gt; {1}&lt;b&gt;Longitude:&lt;/b&gt; {2}.
        /// </summary>
        internal static string GeocodeResult {
            get {
                return ResourceManager.GetString("GeocodeResult", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Hi, I&apos;m Hitagi!.
        /// </summary>
        internal static string Greeting {
            get {
                return ResourceManager.GetString("Greeting", resourceCulture);
            }
        }
    }
}
