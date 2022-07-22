using System.Data;
using NPoco;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;
using Umbraco.Cms.Infrastructure.Persistence.Dtos;

namespace VisitsTracker.Models;

[TableName(TableName)]
[PrimaryKey("Id", AutoIncrement = true)]
[ExplicitColumns]
public class TrackingEntity
{
    public const string TableName = "Tracking";

    
    [PrimaryKeyColumn(AutoIncrement = true, IdentitySeed = 1)]
    [Column("Id")]
    public int Id { get; set; }
    
    [Column("numberOfVisits")]
    public int NumberOfVisits { get; set; }
    
    [Column("nodeId")]
    [ForeignKey(typeof(NodeDto), OnDelete = Rule.Cascade)]
    public int NodeId { get; set; }
}