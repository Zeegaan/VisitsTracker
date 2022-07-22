using TrackerPackage.Models;

namespace TrackerPackage.Mappers;

public interface ITrackingMapper
{
    public Tracking Map(TrackingEntity src);
}