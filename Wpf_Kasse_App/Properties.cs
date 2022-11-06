namespace Wpf_Kasse_App
{
    internal class Properties
    {

        [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.2.0.0")]
        internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase
        {

            private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));

            public static Settings Default
            {
                get
                {
                    return defaultInstance;
                }
            }

            [global::System.Configuration.ApplicationScopedSettingAttribute()]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
            [global::System.Configuration.DefaultSettingValueAttribute("Data Source=\\SQQL2018;Initial Catalog=KasseApplikation_Database;Integrated Security=True")]
            public string connection
            {
                get
                {
                    return ((string)(this["connection"]));
                }
            }
        }
    }
}