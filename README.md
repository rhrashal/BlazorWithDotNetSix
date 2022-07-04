# BlazorWithDotNetSix

### dot net six connection string from appSetting.json
```C#
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DBConnection");
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
```
