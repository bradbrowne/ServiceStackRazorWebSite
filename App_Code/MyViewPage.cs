using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyViewPage
/// </summary>
public class MyViewPage : ServiceStack.Razor.ViewPage
{
    public dynamic Context { get; set; } //Unused, make Razor VS.NET Intelli-sense happy

    public override void Execute()
    {
        throw new NotImplementedException();
    }
}

public class MyViewPage<T> : ServiceStack.Razor.ViewPage<T>
{
    public dynamic Context { get; set; } //Unused, make Razor VS.NET Intelli-sense happy

    public override void Execute()
    {
        throw new NotImplementedException();
    }
}