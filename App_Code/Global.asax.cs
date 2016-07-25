using ServiceStack;
using ServiceStack.Razor;
using System;

public class AppHost : AppHostBase
{
    //Tell ServiceStack the name of your application and where to find your services
    public AppHost() : base("Hello Web Services", typeof(HelloService).Assembly) { }

    public override void Configure(Funq.Container container)
    {
        //register any dependencies your services use, e.g:
        //container.Register<ICacheClient>(new MemoryCacheClient());
        this.Plugins.Add(new RazorFormat());
    }
}