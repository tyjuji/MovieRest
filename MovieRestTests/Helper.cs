using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MovieRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRestTests
{
    public static class Helper
    {
        //private IConfiguration configuration = new ConfigurationBuilder().Build();
        public static Startup asd = new Startup(new ConfigurationBuilder().Build());
        public static ServiceCollection serv = new ServiceCollection{ };
        public static IServiceProvider Provider;
        
        static Helper()
        {
            asd.ConfigureServices(serv);
            Provider = serv.BuildServiceProvider();
        }

        public static T GetRequiredService<T>()
        {
            return Provider.GetRequiredService<T>();
        }

    }
}
