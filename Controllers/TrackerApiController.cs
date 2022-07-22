using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TrackerPackage.Models;
using TrackerPackage.Services;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;

namespace TrackerPackage;

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