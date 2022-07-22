using System.Collections.Generic;
using TrackerPackage.Models;
using Umbraco.Cms.Core.Services;

namespace TrackerPackage.Mappers;

public class TrackingMapper : ITrackingMapper
{
    private readonly IContentService _contentService;

    public TrackingMapper(IContentService contentService)
    {
        _contentService = contentService;
    }
    public Tracking Map(TrackingEntity src)
    {
        var content = _contentService.GetById(src.Id);
        return new()
        {
            ContentId = src.NodeId,
            ContentName = content.PublishName ?? content.Name,
            NumberOfVisits = src.NumberOfVisits,
        };
    }

}