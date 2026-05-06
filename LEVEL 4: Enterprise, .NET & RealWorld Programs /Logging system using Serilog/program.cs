// Install-Package Serilog.Sinks.Console
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();

Log.Information("Hello Logging");
