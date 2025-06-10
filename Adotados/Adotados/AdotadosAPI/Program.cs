﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AdotadosAPI.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AdotadosAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AdotadosAPIContext") ?? throw new InvalidOperationException("Connection string 'AdotadosAPIContext' not found.")));

// Add services to the container.
// Adiciona serviços necessários para a autenticação com JWT
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        string secretKey = "6Thc6smwkRQeFSOGGDDplGZeirGPgBULaUe5EBCfg0xo4YA1OBkuudHiP2T41eg7SmE58hvrxB9CWYgwk9xbdbpEqsYsdMMaIvSey3aea8d2EtWV9C8tGJlmqfROgvZS";

        options.TokenValidationParameters = new TokenValidationParameters
        {

            // Defina o segredo da chave
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),

            // Defina o nome do emisor e do público
            ValidIssuer = "*",
            ValidAudience = "*",

            // Valida as exigências do token
            RequireExpirationTime = true,
            ValidateLifetime = true,
            ClockSkew = TimeSpan.Zero
        };
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//configuração do CORS
//não esquecer de colocar enabledCors nas controllers
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Achados e Amados", Version = "v1" });

    // Adiciona a configuração de segurança para o Swagger
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "Insira o JWT no formato: Bearer {seu_token}",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] { }
        }
    });
});


var app = builder.Build();

// Configure the HTTP request pipeline.

    app.UseSwagger();
    app.UseSwaggerUI();


app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
