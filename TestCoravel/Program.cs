using Microsoft.Extensions.DependencyInjection;
using System;
using Coravel;

namespace TestCoravel

{
    internal class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection services = new ServiceCollection();

            services.AddScheduler();

            services.BuildServiceProvider().UseScheduler(scheduler =>
            {
                scheduler.Schedule<DXAYJob>()
                      .EveryMinute();
                //.DailyAt(16, 0); // UTC Time(台灣凌晨0點)

                var ctbcJobConfigSection = DateTime.Now;
                var hour = ctbcJobConfigSection.Hour;
                var minute = ctbcJobConfigSection.Minute;

                scheduler.Schedule<T01Job>()
                    .DailyAt(hour, minute); // UTC Time(台灣10點)

                var t02Hour = SetHour(hour, minute, 30);
                var t02Minute = SetMinute(minute, 30);

                scheduler.Schedule<T02Job>()
                    .DailyAt(t02Hour, t02Minute); // UTC Time(台灣10點) T01啟動時間+30

                var t03Hour = SetHour(hour, minute, 40);
                var t03Minute = SetMinute(minute, 40);

                scheduler.Schedule<T03Job>()
                    .DailyAt(t03Hour, t03Minute); // UTC Time(台灣10點) T01啟動時間+40

                var t05Hour = SetHour(hour, minute, 50);
                var t05Minute = SetMinute(minute, 50);

                scheduler.Schedule<T05Job>()
                    .DailyAt(t05Hour, t05Minute); // UTC Time(台灣10點) T01啟動時間+50

            });
        }
    }
}
