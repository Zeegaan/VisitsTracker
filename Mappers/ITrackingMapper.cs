using VisitsTracker.Models;

namespace VisitsTracker.Mappers;

public interface ITrackingMapper
{
    public Tracking Map(TrackingEntity src);
}