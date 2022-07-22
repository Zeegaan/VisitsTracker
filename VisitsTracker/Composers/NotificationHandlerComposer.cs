using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Cms.Core.Notifications;
using VisitsTracker.Migrations;

namespace VisitsTracker.Composers;

public class NotificationHandlerComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.AddNotificationHandler<UmbracoApplicationStartingNotification, RunTrackingEntityMigration>();
    }
}