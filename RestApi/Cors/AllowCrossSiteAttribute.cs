
using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class AllowCrossSiteAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        //filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Origin", "http://localhost:4200");
        // filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Headers", "*");
        //filterContext.RequestContext.HttpContext.Response.AddHeader("Access-Control-Allow-Credentials", "true");
        filterContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:4200");
        filterContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Headers", "*");
        filterContext.HttpContext.Response.Headers.Add("Access-Control-Allow-Credentials", "true");
        filterContext.HttpContext.Response.Headers.Add("Vary", "Origin");
        base.OnActionExecuting(filterContext);
    }
}