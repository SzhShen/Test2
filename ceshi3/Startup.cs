﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ceshi3.Startup))]
namespace ceshi3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
