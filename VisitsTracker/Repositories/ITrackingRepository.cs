using System.Collections.Generic;
using VisitsTracker.Models;

namespace VisitsTracker.Repositories;

public interface ITrackingRepository
{
    TrackingEntity GetById(int id);
    void Update(TrackingEntity entity);
    void Save(TrackingEntity entity);
    IEnumerable<TrackingEntity> GetAll();
}