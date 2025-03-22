using SecureTaskManager;

var builder = WebApplication.CreateBuilder(args);

// Create an instance of Startup and pass the builder.Configuration
var startup = new Startup(builder.Configuration);

// Call ConfigureServices method from Startup
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Call Configure method from Startup
startup.Configure(app);

app.Run();