using Abp.Application.Navigation;
using Abp.Localization;

namespace BoilerplateCore.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class BoilerplateCoreNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        PageNames.Osobe,
                        L("Osobe"),
                        url: "Osobe/OsobeGetAll",
                        icon: "fa fa-user"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Kancelarije,
                        L("Kancelarije"),
                        url: "Kancelarija/Kancelarija",
                        icon: "fa fa-building"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Uredjaji,
                        L("Uredjaji"),
                        url: "Uredjaji/GetAllDevices",
                        icon: "fa fa-laptop"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.KoristeniUredjaji,
                        L("KoristeniUredjaji"),
                        url: "KoristeniUredjaji/KoristeniUredjaji",
                        icon: "fa fa-history"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, BoilerplateCoreConsts.LocalizationSourceName);
        }
    }
}

/* .AddItem(
                    new MenuItemDefinition(
                        PageNames.Home,
                        L("HomePage"),
                        url: "",
                        icon: "fa fa-home"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.Kontakt,
                        L("Kontakt"),
                        url: "Home/Kontakt",
                        icon: "fa fa-phone"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        PageNames.About,
                        L("About"),
                        url: "Home/About",
                        icon: "fa fa-info"
                        )
                )
*/