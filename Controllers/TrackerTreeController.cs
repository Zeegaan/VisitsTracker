using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Events;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Trees;
using Umbraco.Cms.Web.BackOffice.Trees;
using Umbraco.Cms.Web.Common.Attributes;

namespace TrackerPackage;
[Tree("tracking", "tracker", IsSingleNodeTree = true, TreeTitle = "Tracker", TreeGroup="trackerGroup", SortOrder=5)]
[PluginController("TrackerPackage")]
public class TrackerTreeController : TreeController
{
    private readonly IMenuItemCollectionFactory _menuItemCollectionFactory;
    
    public TrackerTreeController(ILocalizedTextService localizedTextService, UmbracoApiControllerTypeCollection umbracoApiControllerTypeCollection, IEventAggregator eventAggregator, IMenuItemCollectionFactory menuItemCollectionFactory) : base(localizedTextService, umbracoApiControllerTypeCollection, eventAggregator)
    {
        _menuItemCollectionFactory = menuItemCollectionFactory;
    }

    protected override ActionResult<TreeNodeCollection> GetTreeNodes(string id, FormCollection queryStrings)
    {
        var nodes = new TreeNodeCollection();
        return nodes;
    }

    protected override ActionResult<MenuItemCollection> GetMenuForNode(string id, FormCollection queryStrings)
    {
        // create a Menu Item Collection to return so people can interact with the nodes in your tree
        var menu = _menuItemCollectionFactory.Create();
        return menu;
    }
}