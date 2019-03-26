using System.Reflection;
using Abp.Configuration.Startup;
using Abp.Localization;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Json;
using Abp.Reflection.Extensions;

namespace BoilerplateCore.Localization
{
    public static class BoilerplateCoreLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Languages.Add(new LanguageInfo("en", "English", "famfamfam-flags england", isDefault: true));
            localizationConfiguration.Languages.Add(new LanguageInfo("mne", "Crnogorski", "famfamfam-flags me"));

            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BoilerplateCoreConsts.LocalizationSourceName,
                    new JsonEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BoilerplateCoreLocalizationConfigurer).GetAssembly(),
                        "BoilerplateCore.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}