using ActionFilter.Filter;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(o =>
                                {
                                    //Register filter
                                    o.Filters.Add(new ActionParamFilter());
                                });

var app = builder.Build();

app.MapDefaultControllerRoute();
app.Run();