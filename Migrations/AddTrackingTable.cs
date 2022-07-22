using System.Collections.Generic;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Extensions;
using VisitsTracker.Models;

namespace VisitsTracker.Migrations;

public class AddTrackingTable : MigrationBase
{
    public AddTrackingTable(IMigrationContext context) : base(context)
    {
    }

    protected override void Migrate()
    {
        IEnumerable<string> tables = SqlSyntax.GetTablesInSchema(Context.Database);
        if (!tables.InvariantContains(TrackingEntity.TableName))
        {
            Create.Table<TrackingEntity>().Do();
        }
    }
}