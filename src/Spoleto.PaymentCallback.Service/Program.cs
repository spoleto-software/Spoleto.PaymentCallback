using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.Extensions.Options;
using NLog;
using NLog.Web;
using Spoleto.MQ.Interfaces;
using Spoleto.MQ.Options;
using Spoleto.MQ.Publisher;
using Spoleto.PaymentCallback.Service.Models.AtolOnline;
using Spoleto.PaymentCallback.Service.Services;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
//logger.Debug("Init main");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddOptions();

    //Alfa-Bank:
    builder.Services.Configure<AlfaBankServiceDatabaseSettings>(
        builder.Configuration.GetSection(nameof(AlfaBankServiceDatabaseSettings)));

    builder.Services.AddSingleton<IAlfaServiceDatabaseSettings>(sp =>
        sp.GetRequiredService<IOptions<AlfaBankServiceDatabaseSettings>>().Value);

    builder.Services.AddSingleton<AlfaBankQRCodeReportService>();

    //Atol online:
    builder.Services.Configure<AtolOnlineServiceDatabaseSettings>(
        builder.Configuration.GetSection(nameof(AtolOnlineServiceDatabaseSettings)));

    builder.Services.AddSingleton<IAtolOnlineServiceDatabaseSettings>(sp =>
        sp.GetRequiredService<IOptions<AtolOnlineServiceDatabaseSettings>>().Value);

    builder.Services.AddSingleton<AtolOnlineFiscalRequestService>();

    //MQ Rabbit:
    builder.Services.Configure<MqOption>(builder.Configuration.GetSection(nameof(MqOption)));
    builder.Services.AddSingleton<IMqOption>(sp => sp.GetRequiredService<IOptions<MqOption>>().Value);
    builder.Services.AddSingleton<ISender, EasyRabbitSender>();

    // NLog: Setup NLog for Dependency injection
    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services
        .AddAuthentication(NegotiateDefaults.AuthenticationScheme)
        .AddNegotiate();

    builder.Services.AddAuthorization(options =>
    {
        // By default, all incoming requests will be authorized according to the default policy.
        options.FallbackPolicy = options.DefaultPolicy;
    });

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseAuthentication();
    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}
