﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Renamer.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Renamer.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Renamer.
        /// </summary>
        public static string AppName {
            get {
                return ResourceManager.GetString("AppName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select files.
        /// </summary>
        public static string DialogTitleFileSelect {
            get {
                return ResourceManager.GetString("DialogTitleFileSelect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format:.
        /// </summary>
        public static string Format {
            get {
                return ResourceManager.GetString("Format", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Format must contain &quot;{0}&quot;.
        /// </summary>
        public static string FormatZeroError {
            get {
                return ResourceManager.GetString("FormatZeroError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Mechanism:.
        /// </summary>
        public static string Mechanism {
            get {
                return ResourceManager.GetString("Mechanism", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create date like &quot;yyyy-MM-dd HH-mm-ss&quot;.
        /// </summary>
        public static string MechanismCreateDate {
            get {
                return ResourceManager.GetString("MechanismCreateDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incremental.
        /// </summary>
        public static string MechanismIncremental {
            get {
                return ResourceManager.GetString("MechanismIncremental", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to MD5 Hash.
        /// </summary>
        public static string MechanismMD5 {
            get {
                return ResourceManager.GetString("MechanismMD5", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select &amp; Rename.
        /// </summary>
        public static string SelectAndRename {
            get {
                return ResourceManager.GetString("SelectAndRename", resourceCulture);
            }
        }
    }
}