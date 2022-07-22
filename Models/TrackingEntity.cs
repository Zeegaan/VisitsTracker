using NPoco;
using Umbraco.Cms.Infrastructure.Persistence.DatabaseAnnotations;
using Umbraco.Cms.Infrastructure.Persistence.Dtos;

namespace TrackerPackage.Models;

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
    [ForeignKey(typeof(NodeDto))]
    public int NodeId { get; set; }
}