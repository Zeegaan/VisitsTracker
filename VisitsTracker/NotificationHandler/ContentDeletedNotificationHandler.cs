using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Notifications;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Scoping;
using VisitsTracker.Repositories;

namespace VisitsTracker.NotificationHandler;

public class ContentDeletedNotificationHandler : INotificationHandler<ContentDeletedNotification>
{
    private readonly IContentService _contentService;
    private readonly ITrackingRepository _repository;
    private readonly IScopeProvider _scopeProvider;

    public ContentDeletedNotificationHandler(IContentService contentService, ITrackingRepository repository, IScopeProvider scopeProvider)
    {
        _contentService = contentService;
        _repository = repository;
        _scopeProvider = scopeProvider;
    }
    public void Handle(ContentDeletedNotification notification)
    {
        using var scope = _scopeProvider.CreateScope();
        foreach (var content in notification.DeletedEntities)
        {
            var entity = _repository.GetById(content.Id);
            _repository.Delete(entity);
        }

        scope.Complete();
    }
}