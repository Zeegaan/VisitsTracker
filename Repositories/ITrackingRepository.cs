using System.Collections.Generic;
using TrackerPackage.Models;

namespace TrackerPackage.Repositories;

public interface ITrackingRepository
{
    TrackingEntity GetById(int id);
    void Update(TrackingEntity entity);
    void Save(TrackingEntity entity);
    IEnumerable<TrackingEntity> GetAll();
}