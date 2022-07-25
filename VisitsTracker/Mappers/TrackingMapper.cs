using Umbraco.Cms.Core.Services;
using VisitsTracker.Models;

namespace VisitsTracker.Mappers;

public class TrackingMapper : ITrackingMapper
{
    private readonly IContentService _contentService;
    private readonly IContentTypeService _contentTypeService;

    public TrackingMapper(IContentService contentService, IContentTypeService contentTypeService)
    {
        _contentService = contentService;
        _contentTypeService = contentTypeService;
    }
    public Tracking Map(TrackingEntity src)
    {
        var content = _contentService.GetById(src.NodeId);
        return new()
        {
            ContentId = src.NodeId,
            ContentName = content.Name,
            NumberOfVisits = src.NumberOfVisits,
            Icon = _contentTypeService.Get(content.ContentTypeId).Icon,
        };
    }

}