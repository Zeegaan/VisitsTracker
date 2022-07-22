using System.Collections.Generic;
using TrackerPackage.Models;

namespace TrackerPackage.Services;

public interface ITrackingService
{
    IEnumerable<Tracking> GetAll();
    void ReportVisit(int contentId);
}