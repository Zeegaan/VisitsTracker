using System.Collections.Generic;
using TrackerPackage.Models;
using Umbraco.Cms.Infrastructure.Migrations;
using Umbraco.Extensions;

namespace TrackerPackage.Migrations;

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