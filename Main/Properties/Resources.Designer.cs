﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FoenixIDE.Simulator.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("FoenixIDE.Simulator.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap delete_btn {
            get {
                object obj = ResourceManager.GetObject("delete_btn", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Byte[].
        /// </summary>
        internal static byte[] kernel_U_Plus_Hex {
            get {
                object obj = ResourceManager.GetObject("kernel_U_Plus_Hex", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 
        ///; 64tass Turbo Assembler Macro V1.54.1900 listing file
        ///; 64tass --m65816 -D TARGET=1 -D TARGET_SYS=3 --long-address --flat -b -o kernel_U_Plus.bin --list kernel_U_Plus.lst --labels=kernel_U_Plus.lbl src\kernel.asm
        ///; Fri Feb 19 14:45:31 2021
        ///
        ///;Offset	;PC	;Hex		;Monitor	;Source
        ///
        ///;******  Command line definitions
        ///
        ///=1						TARGET=1
        ///=3						TARGET_SYS=3
        ///
        ///;******  Processing input file: src\kernel.asm
        ///
        ///=0						TEST_KEYBOARD = 0 ; This is to enable the ScreenOutput
        ///=1						SYS_C256_FMX = 1          [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string kernel_U_Plus_Lst {
            get {
                return ResourceManager.GetString("kernel_U_Plus_Lst", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap memory_btn {
            get {
                object obj = ResourceManager.GetObject("memory_btn", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
