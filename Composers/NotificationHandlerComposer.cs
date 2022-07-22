using TrackerPackage.Migrations;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;

namespace TrackerPackage.Composers;

public class NotificationHandlerComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddNotificationHandler<UmbracoApplicationStartingNotification, RunTrackingEntityMigration>();
    }
}