﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.269
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MergeMSI.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MergeMSI.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
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
        ///   Sucht eine lokalisierte Zeichenfolge, die &apos; Windows Installer utility to report the language and codepage for a package
        ///&apos; For use with Windows Scripting Host, CScript.exe or WScript.exe
        ///&apos; Copyright (c) Microsoft Corporation. All rights reserved.
        ///&apos; Demonstrates the access of language and codepage values                 
        ///&apos;
        ///&apos; Team MediaPortal note:
        ///&apos; Only modification is to comment the messagebox at the of the process. (around line 71)
        ///Option Explicit
        ///
        ///Const msiOpenDatabaseModeReadOnly     = 0
        ///Const msiOpenDatabaseModeTransact     = 1
        ///Const [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string WiLangId {
            get {
                return ResourceManager.GetString("WiLangId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die &apos; Windows Installer utility to add a transform or nested database as a substorage
        ///&apos; For use with Windows Scripting Host, CScript.exe or WScript.exe
        ///&apos; Copyright (c) Microsoft Corporation. All rights reserved.
        ///&apos; Demonstrates the use of the database _Storages table
        ///&apos;
        ///Option Explicit
        ///
        ///Const msiOpenDatabaseModeReadOnly     = 0
        ///Const msiOpenDatabaseModeTransact     = 1
        ///Const msiOpenDatabaseModeCreate       = 3
        ///
        ///Const msiViewModifyInsert         = 1
        ///Const msiViewModifyUpdate         = 2
        ///Const msiViewM [Rest der Zeichenfolge wurde abgeschnitten]&quot;; ähnelt.
        /// </summary>
        internal static string WiSubStg {
            get {
                return ResourceManager.GetString("WiSubStg", resourceCulture);
            }
        }
    }
}
