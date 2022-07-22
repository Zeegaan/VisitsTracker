using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;
using VisitsTracker.Mappers;
using VisitsTracker.Repositories;
using VisitsTracker.Services;

namespace VisitsTracker.Composers;

public class ServicesComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.AddUnique<ITrackingService, TrackingService>();
        builder.Services.AddUnique<ITrackingMapper, TrackingMapper>();
        builder.Services.AddUnique<ITrackingRepository, TrackingRepository>();
    }
}