var builder = WebApplication.CreateBuilder(args);

// add service to cointainer



var app = builder.Build();

//configure the http request



app.Run();
