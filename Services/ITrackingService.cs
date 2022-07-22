using System.Collections.Generic;
using VisitsTracker.Models;

namespace VisitsTracker.Services;

public interface ITrackingService
{
    IEnumerable<Tracking> GetAll();
    void ReportVisit(int contentId);
}