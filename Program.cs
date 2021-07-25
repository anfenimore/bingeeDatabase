using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using watchlist.models;

namespace watchlist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CreateHostBuilder(args).Build().Run();

            // Show testShow = new Show();
            // testShow.userId = 1;
            // testShow.showId = 15189;
            // testShow.name = "GossippGirl";
            // testShow.image_thumbnail_path = "https://static.episodate.com/images/tv-show/thumbnail/15189.jpg";
            // testShow.network = "The CW";

            // SaveShow insertObject = new SaveShow();
            // insertObject.CreateShow(testShow);

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
