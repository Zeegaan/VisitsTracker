using System.Collections.Generic;
using System.Linq;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Infrastructure.Persistence.Repositories.Implement;
using Umbraco.Cms.Infrastructure.Scoping;
using Umbraco.Extensions;
using VisitsTracker.Models;

namespace VisitsTracker.Repositories;

public class TrackingRepository : RepositoryBase, ITrackingRepository
{
    public TrackingRepository(IScopeAccessor scopeAccessor, AppCaches appCaches) : base(scopeAccessor, appCaches)
    {
    }

    public TrackingEntity GetById(int id)
    {
        var sql = SqlContext.Sql()
            .Select<TrackingEntity>()
            .From<TrackingEntity>()
            .Where<TrackingEntity>(x => x.NodeId == id);

        return Database.Fetch<TrackingEntity>(sql).FirstOrDefault();
    }

    public void Update(TrackingEntity entity)
    {
        Database.Update(entity);
    }

    public void Save(TrackingEntity entity)
    {
        Database.Save(entity);
    }
    
    public IEnumerable<TrackingEntity> GetAll()
    {
        var sql = SqlContext.Sql()
            .Select<TrackingEntity>()
            .From<TrackingEntity>();

        return Database.Fetch<TrackingEntity>(sql);
    }
}