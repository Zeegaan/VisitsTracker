using System.Collections.Generic;
using TrackerPackage.Mappers;
using TrackerPackage.Models;
using TrackerPackage.Repositories;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Scoping;
using Umbraco.Extensions;

namespace TrackerPackage.Services;

public class TrackingService : ITrackingService
{
    private readonly IScopeProvider _scopeProvider;
    private readonly IContentService _contentService;
    private readonly ITrackingRepository _trackingRepository;
    private readonly ITrackingMapper _trackingMapper;

    public TrackingService(
        IScopeProvider scopeProvider,
        IContentService contentService,
        ITrackingRepository trackingRepository,
        ITrackingMapper trackingMapper)
    {
        _scopeProvider = scopeProvider;
        _contentService = contentService;
        _trackingRepository = trackingRepository;
        _trackingMapper = trackingMapper;
    }

    public IEnumerable<Tracking> GetAll()
    {
        IEnumerable<TrackingEntity> entities;

        using (_scopeProvider.CreateScope(autoComplete: true))
        {
            entities = _trackingRepository.GetAll().WhereNotNull();
        }

        foreach (var entity in entities)
        {
            yield return _trackingMapper.Map(entity);
        }
    }

    public void ReportVisit(int contentId)
    {
        using var scope = _scopeProvider.CreateScope();
        var entity = _trackingRepository.GetById(contentId);

        if (entity is not TrackingEntity trackingEntity)
        {
            trackingEntity = new TrackingEntity
            {
                NodeId = contentId,
                NumberOfVisits = 1,
            };

            _trackingRepository.Save(trackingEntity);
            scope.Complete();
        }
        else
        {
            trackingEntity.NumberOfVisits++;
            _trackingRepository.Update(trackingEntity);
            scope.Complete();
        }
    }
}