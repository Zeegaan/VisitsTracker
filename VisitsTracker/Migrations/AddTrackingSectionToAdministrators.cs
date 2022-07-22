using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Infrastructure.Migrations;

namespace TrackerPackage.Migrations;

public class AddTrackingSectionToAdministrators : MigrationBase
{
    private readonly IUserService _userService;

    public AddTrackingSectionToAdministrators(IMigrationContext context, IUserService userService) : base(context)
    {
        _userService = userService;
    }

    protected override void Migrate()
    {
        var adminUserGroup = _userService.GetUserGroupByAlias(Constants.Security.AdminGroupAlias);
        if (adminUserGroup is not null)
        {
            adminUserGroup.AddAllowedSection("tracking");
            _userService.Save(adminUserGroup);
        }
    }
}