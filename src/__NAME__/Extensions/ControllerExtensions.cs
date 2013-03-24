using System.Web.Mvc;
using __NAME__.Components.Security;

public static class ControllerExtensions
{
    public static CustomPrincipal GetCurrentPrincipal(this Controller controller)
    {
        return controller.HttpContext.User as CustomPrincipal;
    }
}