﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grabacr07.KanColleViewer.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("37564")]
        public int LocalProxyPort {
            get {
                return ((int)(this["LocalProxyPort"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"body {
    margin:0;
    overflow:hidden;
}

#game_frame {
    position:fixed;
    left:50%;
    top:-16px;
    margin-left:-450px;
    z-index:1;
}

#flashWrap {
    position:free;
    z-index:1;
    margin:0;
}

#spacing_top, #sectionWrap {
    visibility: hidden !important;
    height:0 !important;
    display: none !important;
}")]
        public string OverrideStyleSheet {
            get {
                return ((string)(this["OverrideStyleSheet"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("480")]
        public double UIContentWidth {
            get {
                return ((double)(this["UIContentWidth"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8000")]
        public int FeatureBrowserEmulation {
            get {
                return ((int)(this["FeatureBrowserEmulation"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"function kcsFlash_StartFlash(worldServerAddr)
{{
    // Flash パラメータを設定する。
    var flashParams =
    {{
        ""id""                : ""externalswf"",
        ""width""             : ""800"",
        ""height""            : ""480"",
        ""wmode""             : ""{1}"",
        ""quality""           : ""{0}"",
        ""bgcolor""           : ""#000000"",
        ""allowScriptAccess"" : ""always""
    }};

    // Flash の貼り付けに失敗した場合のメッセージを設定する。
    document.getElementById(""flashWrap"").innerHTML = ConstMessageInfo.InstallFlashMessage;

    // Flash をページに貼り付ける。
    gadgets.flash.embedFlash(
        worldServerAddr + ConstURLInfo.MainFlashURL + ""?api_token="" + flashInfo.apiToken + 
                                  ""&amp;api_starttime="" + flashInfo.apiStartTime,
        document.getElementById(""flashWrap""),
        6,
        flashParams
    );

    // サンクスページ用フラッシュのエリアの高さを変更する。
    document.getElementById(""adFlashWrap"").style.height = ""0px"";

    // ワールド選択用フラッシュのエリアの高さを変更する。
    document.getElementById(""wsFlashWrap"").style.height = ""0px"";

    // ゲーム用フラッシュのエリアのエリアの高さを変更する。
    document.getElementById(""flashWrap"").style.height = ""480px"";

    // ガジェットの高さを調整する。
    gadgets.window.adjustHeight(ConstGadgetInfo.height);
}}")]
        public string FlashQualityJS {
            get {
                return ((string)(this["FlashQualityJS"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<embed id=\"KCVGenerated\" width=\"800\" height=\"480\" wmode=\"{1}\" quality=\"{0}\" bgcol" +
            "or=\"#000\" allowScriptAccess=\"always\" type=\"application/x-shockwave-flash\" src=\"{" +
            "2}\">")]
        public string FlashEmbed {
            get {
                return ((string)(this["FlashEmbed"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://yuyuvn.github.io/KanColleViewer/resources/Version.xml")]
        public global::System.Uri KCVUpdateUrl {
            get {
                return ((global::System.Uri)(this["KCVUpdateUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://yuyuvn.github.io/KanColleViewer/resources/Version.xml")]
        public global::System.Uri KCVUpdateTransUrl {
            get {
                return ((global::System.Uri)(this["KCVUpdateTransUrl"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/")]
        public global::System.Uri KanColleUrl {
            get {
                return ((global::System.Uri)(this["KanColleUrl"]));
            }
        }
    }
}
