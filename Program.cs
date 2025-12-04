using ProductsApi.Repositories;
using ProductsApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Lisää palvelut
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Rekisteröidään Repository ja Service DI:hen
builder.Services.AddScoped<ProductsRepository>();
builder.Services.AddScoped<ProductsService>();
builder.Services.AddScoped<CategoriesRepository>();
builder.Services.AddScoped<CategoriesService>();

var app = builder.Build();

// Swagger dev-ympäristöissä
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Käytetään contollereita
app.MapControllers();

app.Run();
