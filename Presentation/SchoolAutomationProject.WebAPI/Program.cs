using SchoolAutomationProject.Persistence.IoCContainer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddPersistenceServices(builder.Configuration);

builder.Services.AddCors(options => options.AddPolicy("SchoolAutomationProject", policy => policy
    .WithOrigins("https://localhost:7070")
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
));
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("SchoolAutomationProject");
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
