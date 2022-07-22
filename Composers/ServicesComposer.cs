using TrackerPackage.Mappers;
using TrackerPackage.Repositories;
using TrackerPackage.Services;
using Umbraco.Cms.Core.Composing;
using Umbraco.Cms.Core.DependencyInjection;
using Umbraco.Extensions;

namespace TrackerPackage.Composers;

public class ServicesComposer : IComposer
{
    public void Compose(IUmbracoBuilder builder)
    {
        builder.Services.AddUnique<ITrackingService, TrackingService>();
        builder.Services.AddUnique<ITrackingMapper, TrackingMapper>();
        builder.Services.AddUnique<ITrackingRepository, TrackingRepository>();
    }
}