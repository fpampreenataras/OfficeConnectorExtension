﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorkflowWordAddIn.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.1.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("arasPrimaryLinkItemId")]
        public string arasPrimaryLinkItemId {
            get {
                return ((string)(this["arasPrimaryLinkItemId"]));
            }
            set {
                this["arasPrimaryLinkItemId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("url")]
        public string ArasURL {
            get {
                return ((string)(this["ArasURL"]));
            }
            set {
                this["ArasURL"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("db")]
        public string ARASdb {
            get {
                return ((string)(this["ARASdb"]));
            }
            set {
                this["ARASdb"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ArasInfo")]
        public string ArasInfoNodeName {
            get {
                return ((string)(this["ArasInfoNodeName"]));
            }
            set {
                this["ArasInfoNodeName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("arasPrimaryLinkItemId")]
        public string ArasPrimaryLinkIDName {
            get {
                return ((string)(this["ArasPrimaryLinkIDName"]));
            }
            set {
                this["ArasPrimaryLinkIDName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<AML><Item type=\"Workflow\" action=\"get\"><source_id></source_id></Item></AML>")]
        public string getWorkFlowAML {
            get {
                return ((string)(this["getWorkFlowAML"]));
            }
            set {
                this["getWorkFlowAML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<AML><Item type=\"Workflow Process\" action=\"get\"><id></id></Item></AML>")]
        public string getWorkFlowProcessAML {
            get {
                return ((string)(this["getWorkFlowProcessAML"]));
            }
            set {
                this["getWorkFlowProcessAML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<AML>\r\n<Item type=\"Workflow Map\" action=\"get\" select=\"name\">\r\n<id></id>\r\n</Item>\r" +
            "\n\r\n</AML>")]
        public string getWorkflowMapNameAML {
            get {
                return ((string)(this["getWorkflowMapNameAML"]));
            }
            set {
                this["getWorkflowMapNameAML"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<AML>\r\n<Item type=\"Workflow Process Activity\" action=\"get\" select=\"related_id\">\r\n" +
            "<source_id></source_id>\r\n</Item>\r\n</AML>")]
        public string getActivitiesAML {
            get {
                return ((string)(this["getActivitiesAML"]));
            }
            set {
                this["getActivitiesAML"] = value;
            }
        }
    }
}