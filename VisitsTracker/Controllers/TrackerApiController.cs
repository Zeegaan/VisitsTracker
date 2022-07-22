using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;
using VisitsTracker.Models;
using VisitsTracker.Services;

namespace VisitsTracker;

[PluginController("My")]
public class TrackerApiController : UmbracoAuthorizedJsonController
{
    private readonly ITrackingService _trackingService;

    public TrackerApiController(ITrackingService trackingService)
    {
        _trackingService = trackingService;
    }
    
    [HttpGet]
    public IEnumerable<Tracking> GetAll()
    {
        return _trackingService.GetAll();
    }
}