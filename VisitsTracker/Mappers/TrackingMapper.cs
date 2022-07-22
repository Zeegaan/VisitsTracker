using Umbraco.Cms.Core.Services;
using VisitsTracker.Models;

namespace VisitsTracker.Mappers;

public class TrackingMapper : ITrackingMapper
{
    private readonly IContentService _contentService;

    public TrackingMapper(IContentService contentService)
    {
        _contentService = contentService;
    }
    public Tracking Map(TrackingEntity src)
    {
        var content = _contentService.GetById(src.NodeId);
        return new()
        {
            ContentId = src.NodeId,
            ContentName = content?.PublishName ?? content?.Name,
            NumberOfVisits = src.NumberOfVisits,
        };
    }

}