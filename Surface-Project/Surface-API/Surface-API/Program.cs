using API.ExtAuthorization;
using Common.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Services.Implementations;
using Services.Interfaces;
using Surface.API.ExtAuthorization;
using Surface.API.Middlewares;
using Surface.BusinessAccessLayer.Services.Architecture;
using Surface.BusinessAccessLayer.Services.Infrastructure;
using Surface.Common.Constants;
using Surface.DataAccessLayer.Repositories.Architecture;
using Surface.DataAccessLayer.Repositories.Infrastructure;
using Surface_BusinessLayer.Services.Architecture;
using Surface_BusinessLayer.Services.Infrastructure;
using Surface_Entities.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson();
builder.Services.AddDbContext<SurfaceContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc(SwaggerConstants.NAME, new OpenApiInfo { Title = SwaggerConstants.TITLE, Version = SwaggerConstants.VERSION });
    c.AddSecurityDefinition(SwaggerConstants.SECURITY_SCHEME, new OpenApiSecurityScheme()
    {
        Name = SwaggerConstants.SECURITY_SCHEME_NAME,
        Type = SecuritySchemeType.ApiKey,
        Scheme = SwaggerConstants.SECURITY_SCHEME,
        BearerFormat = SwaggerConstants.SECURITY_SCHEME_FORMAT,
        In = ParameterLocation.Header,
        Description = SwaggerConstants.SECURITY_SCHEME_DESCRIPTION
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = SwaggerConstants.SECURITY_SCHEME
                        }
                    },
                    Array.Empty<string>()
                }
            });
});

builder.Services.AddTransient<ExceptionMiddleware>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped(typeof(IBaseRepo<>), typeof(BaseRepo<>));
builder.Services.AddScoped(typeof(IBaseService<>), typeof(BaseService<>));
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddSingleton<ITokenBlacklistService, TokenBlacklistService>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAny", policy =>
    {
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
        policy.WithOrigins("http://localhost:4200");
        policy.AllowCredentials();
    });
});

// Custom Auth filter
builder.Services.AddScoped<ExtAuthorizeFilter>();

// Register the ExtAuthorizeHandler before adding policies
builder.Services.AddSingleton<IAuthorizationHandler, ExtAuthorizeHandler>();

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(SystemConstant.ADMIN_POLICY, policy =>
    {
        policy.Requirements.Add(new ExtAuthorizeRequirement(SystemConstant.ADMIN_POLICY));
    });

    
});

builder.Services.AddMemoryCache();

builder.Services.AddHttpContextAccessor();

// Configure the HTTP request pipeline.
var app = builder.Build();
app.UseCors(SystemConstant.CORS_ALLOW_ANY);
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseMiddleware<ExceptionMiddleware>();

app.UseAuthorization();

app.MapControllers();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<SurfaceContext>();
    context.Database.Migrate();
}
app.Run();
