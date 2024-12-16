

// // // // using Microsoft.EntityFrameworkCore;
// // // // using TodoApi;  // Import your classes, including TodoItem

// // // // var builder = WebApplication.CreateBuilder(args);

// // // // // Add CORS service to allow requests from any origin (useful for client apps like React or Angular)
// // // // builder.Services.AddEndpointsApiExplorer();
// // // // builder.Services.AddSwaggerGen();
// // // // builder.Services.AddCors(options =>
// // // // {
// // // //     options.AddDefaultPolicy(builder =>
// // // //     {
// // // //         builder.AllowAnyOrigin()    // Allow any origin (this is for development, change it for production)
// // // //                .AllowAnyMethod()    // Allow any HTTP method (GET, POST, PUT, DELETE)
// // // //                .AllowAnyHeader();   // Allow any header
// // // //     });
// // // // });

// // // // // Get the connection string from the app configuration
// // // // var connectionString = builder.Configuration.GetConnectionString("ToDoDB");

// // // // if (string.IsNullOrEmpty(connectionString))
// // // // {
// // // //     Console.WriteLine("Connection string is missing!");
// // // //     return;
// // // // }

// // // // // Register the DbContext with the connection string
// // // // builder.Services.AddDbContext<ToDoDbContext>(options =>
// // // //     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));  // Use MySQL, change to UseSqlServer if using SQL Server

// // // // // Build the application
// // // // var app = builder.Build();

// // // // // Enable CORS in the pipeline
// // // // app.UseCors();

// // // // // Enable Swagger UI in development environment
// // // // if (app.Environment.IsDevelopment())
// // // // {
// // // //     app.UseSwagger();
// // // //     app.UseSwaggerUI();
// // // // }

// // // // // API Endpoints
// // // // app.MapGet("/", async (ToDoDbContext dbContext) =>
// // // // {
// // // //     if (dbContext == null)
// // // //     {
// // // //         return Results.Problem("Database context is not available.");
// // // //     }

// // // //     var items = await dbContext.Items.ToListAsync();
// // // //     return Results.Json(items);
// // // // });

// // // // app.MapPost("/", async (ToDoDbContext dbContext, Item newItem) =>
// // // // {
// // // //     if (dbContext == null)
// // // //     {
// // // //         return Results.Problem("Database context is not available.");
// // // //     }

// // // //     if (newItem == null)
// // // //     {
// // // //         return Results.BadRequest("Item data is missing.");
// // // //     }

// // // //     dbContext.Items.Add(newItem);
// // // //     await dbContext.SaveChangesAsync();

// // // //     return Results.Created($"/{newItem.Id}", newItem);
// // // // });

// // // // app.MapPut("/{id}", async (int id, ToDoDbContext dbContext, Item updatedItem) =>
// // // // {
// // // //     if (dbContext == null)
// // // //     {
// // // //         return Results.Problem("Database context is not available.");
// // // //     }

// // // //     if (updatedItem == null)
// // // //     {
// // // //         return Results.BadRequest("Updated item data is missing.");
// // // //     }

// // // //     var item = await dbContext.Items.FindAsync(id);
// // // //     if (item == null)
// // // //     {
// // // //         return Results.NotFound(new { Message = "Todo item not found." });
// // // //     }
// // // //     if(updatedItem.Name!=null){
// // // //     item.Name = updatedItem.Name;}
// // // //     if(updatedItem.IsComplete!=null){
// // // //     item.IsComplete = updatedItem.IsComplete;
// // // //     }
// // // //     await dbContext.SaveChangesAsync();

// // // //     return Results.Json(item);
// // // // });

// // // // app.MapDelete("/{id}", async (int id, ToDoDbContext dbContext) =>
// // // // {
// // // //     if (dbContext == null)
// // // //     {
// // // //         return Results.Problem("Database context is not available.");
// // // //     }

// // // //     var item = await dbContext.Items.FindAsync(id);
// // // //     if (item == null)
// // // //     {
// // // //         return Results.NotFound(new { Message = "Todo item not found." });
// // // //     }

// // // //     dbContext.Items.Remove(item);
// // // //     await dbContext.SaveChangesAsync();

// // // //     return Results.Ok(new { Message = "Todo item deleted." });
// // // // });

// // // // app.Run();
// // // using Microsoft.EntityFrameworkCore;
// // // using TodoApi;  // Import your classes, including TodoItem

// // // var builder = WebApplication.CreateBuilder(args);

// // // // Add CORS service to allow requests from any origin (useful for client apps like React or Angular)
// // // builder.Services.AddEndpointsApiExplorer();
// // // builder.Services.AddSwaggerGen();
// // // builder.Services.AddCors(options =>
// // // {
// // //     options.AddDefaultPolicy(builder =>
// // //     {
// // //         builder.AllowAnyOrigin()    // Allow any origin (this is for development, change it for production)
// // //                .AllowAnyMethod()    // Allow any HTTP method (GET, POST, PUT, DELETE)
// // //                .AllowAnyHeader();   // Allow any header
// // //     });
// // // });

// // // // Get the connection string from the app configuration
// // // var connectionString = builder.Configuration.GetConnectionString("ToDoDB");

// // // if (string.IsNullOrEmpty(connectionString))
// // // {
// // //     Console.WriteLine("Connection string is missing!");
// // //     return;
// // // }

// // // // Register the DbContext with the connection string
// // // builder.Services.AddDbContext<ToDoDbContext>(options =>
// // //     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));  // Use MySQL, change to UseSqlServer if using SQL Server

// // // // Build the application
// // // var app = builder.Build();

// // // // Enable CORS in the pipeline
// // // app.UseCors();

// // // // Enable Swagger UI in development environment
// // // if (app.Environment.IsDevelopment())
// // // {
// // //     app.UseSwagger();
// // //     app.UseSwaggerUI();
// // // }

// // // // API Endpoints
// // // app.MapGet("/", async (ToDoDbContext dbContext) =>
// // // {
// // //     if (dbContext == null)
// // //     {
// // //         return Results.Problem("Database context is not available.");
// // //     }

// // //     var items = await dbContext.Items.ToListAsync();
// // //     return Results.Json(items);
// // // });

// // // app.MapPost("/", async (ToDoDbContext dbContext, Item newItem) =>
// // // {
// // //     if (dbContext == null)
// // //     {
// // //         return Results.Problem("Database context is not available.");
// // //     }

// // //     if (newItem == null)
// // //     {
// // //         return Results.BadRequest("Item data is missing.");
// // //     }

// // //     dbContext.Items.Add(newItem);
// // //     await dbContext.SaveChangesAsync();

// // //     return Results.Created($"/{newItem.Id}", newItem);
// // // });

// // // app.MapPut("/{id}", async (int id, ToDoDbContext dbContext, Item updatedItem) =>
// // // {
// // //     if (dbContext == null)
// // //     {
// // //         return Results.Problem("Database context is not available.");
// // //     }

// // //     if (updatedItem == null)
// // //     {
// // //         return Results.BadRequest("Updated item data is missing.");
// // //     }

// // //     var item = await dbContext.Items.FindAsync(id);
// // //     if (item == null)
// // //     {
// // //         return Results.NotFound(new { Message = "Todo item not found." });
// // //     }
// // //     if (updatedItem.Name != null)
// // //     {
// // //         item.Name = updatedItem.Name;
// // //     }
// // //     if (updatedItem.IsComplete != null)
// // //     {
// // //         item.IsComplete = updatedItem.IsComplete;
// // //     }
// // //     await dbContext.SaveChangesAsync();

// // //     return Results.Json(item);
// // // });

// // // app.MapDelete("/{id}", async (int id, ToDoDbContext dbContext) =>
// // // {
// // //     if (dbContext == null)
// // //     {
// // //         return Results.Problem("Database context is not available.");
// // //     }

// // //     var item = await dbContext.Items.FindAsync(id);
// // //     if (item == null)
// // //     {
// // //         return Results.NotFound(new { Message = "Todo item not found." });
// // //     }

// // //     dbContext.Items.Remove(item);
// // //     await dbContext.SaveChangesAsync();

// // //     return Results.Ok(new { Message = "Todo item deleted." });
// // // });

// // // // Register Endpoint
// // // app.MapPost("/register", async (ToDoDbContext dbContext, User newUser) =>
// // // {
// // //     if (dbContext == null)
// // //     {
// // //         return Results.Problem("Database context is not available.");
// // //     }

// // //     if (string.IsNullOrEmpty(newUser.Username) || string.IsNullOrEmpty(newUser.Password))
// // //     {
// // //         return Results.BadRequest("Username and Password are required.");
// // //     }

// // //     var existingUser = await dbContext.Users.FirstOrDefaultAsync(u => u.Username == newUser.Username);
// // //     if (existingUser != null)
// // //     {
// // //         return Results.BadRequest("Username already exists.");
// // //     }

// // //     // Hash the password (in production, use a secure hashing algorithm like BCrypt)
// // //     newUser.Password = BCrypt.Net.BCrypt.HashPassword(newUser.Password);

// // //     dbContext.Users.Add(newUser);
// // //     await dbContext.SaveChangesAsync();

// // //     return Results.Ok(new { Message = "User registered successfully." });
// // // });

// // // // Login Endpoint
// // // app.MapPost("/login", async (ToDoDbContext dbContext, User loginUser) =>
// // // {
// // //     if (dbContext == null)
// // //     {
// // //         return Results.Problem("Database context is not available.");
// // //     }

// // //     if (string.IsNullOrEmpty(loginUser.Username) || string.IsNullOrEmpty(loginUser.Password))
// // //     {
// // //         return Results.BadRequest("Username and Password are required.");
// // //     }

// // //     var user = await dbContext.Users.FirstOrDefaultAsync(u => u.Username == loginUser.Username);
// // //     if (user == null || !BCrypt.Net.BCrypt.Verify(loginUser.Password, user.Password))
// // //     {
// // //         return Results.Unauthorized();
// // //     }

// // //     return Results.Ok(new { Message = "Login successful." });
// // // });

// // // app.Run();
// // using System.IdentityModel.Tokens.Jwt;
// // using System.Security.Claims;
// // using System.Text;
// // using Microsoft.AspNetCore.Authentication.JwtBearer;
// // using Microsoft.EntityFrameworkCore;
// // using Microsoft.IdentityModel.Tokens;
// // using TodoApi;

// // var builder = WebApplication.CreateBuilder(args);

// // // Add services to the container
// // builder.Services.AddEndpointsApiExplorer();
// // builder.Services.AddSwaggerGen();

// // // Add CORS service
// // builder.Services.AddCors(options =>
// // {
// //     options.AddDefaultPolicy(policy =>
// //     {
// //         policy.AllowAnyOrigin()
// //               .AllowAnyMethod()
// //               .AllowAnyHeader();
// //     });
// // });

// // // Get the connection string from app configuration
// // var connectionString = builder.Configuration.GetConnectionString("ToDoDB");

// // if (string.IsNullOrEmpty(connectionString))
// // {
// //     Console.WriteLine("Connection string is missing!");
// //     return;
// // }

// // builder.Services.AddDbContext<ToDoDbContext>(options =>
// //     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
// // // string secretKey = builder.Configuration["JWT:SecretKey"];
// // string secretKey = builder.Configuration["JWT:SecretKey"] ?? throw new ArgumentNullException("JWT:SecretKey is missing");

// // // Add JWT Authentication
// // var key = Encoding.ASCII.GetBytes(secretKey); // Secret Key
// // builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
// //     .AddJwtBearer(options =>
// //     {
// //         options.TokenValidationParameters = new TokenValidationParameters
// //         {
// //             ValidateIssuer = false,
// //             ValidateAudience = false,
// //             ValidateLifetime = true,
// //             ValidateIssuerSigningKey = true,
// //             IssuerSigningKey = new SymmetricSecurityKey(key)
// //         };
// //     });

// // var app = builder.Build();

// // app.UseCors();
// // app.UseAuthentication(); // Enable JWT Authentication
// // app.UseAuthorization();  // Enable Authorization Middleware

// // if (app.Environment.IsDevelopment())
// // {
// //     app.UseSwagger();
// //     app.UseSwaggerUI();
// // }

// // // Login Endpoint
// // app.MapPost("/login", async (User loginRequest, ToDoDbContext dbContext) =>
// // {
// //     var user = await dbContext.Users.SingleOrDefaultAsync(u => u.Username == loginRequest.Username);
// //     if (user == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.Password))
// //     {
// //         return Results.Unauthorized();
// //     }

// //     // Generate JWT
// //     var claims = new[]
// //     {
// //         new Claim(ClaimTypes.Name, user.Username),
// //         new Claim("UserId", user.Id.ToString())
// //     };

// //     var tokenDescriptor = new SecurityTokenDescriptor
// //     {
// //         Subject = new ClaimsIdentity(claims),
// //         Expires = DateTime.UtcNow.AddHours(1),
// //         SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
// //     };

// //     var tokenHandler = new JwtSecurityTokenHandler();
// //     var token = tokenHandler.CreateToken(tokenDescriptor);

// //     return Results.Json(new { Token = tokenHandler.WriteToken(token) });
// // });

// // // Register Endpoint
// // app.MapPost("/register", async (User registerRequest, ToDoDbContext dbContext) =>
// // {
// //     if (string.IsNullOrEmpty(registerRequest.Username) || string.IsNullOrEmpty(registerRequest.Password))
// //     {
// //         return Results.BadRequest("Username and password are required.");
// //     }

// //     var existingUser = await dbContext.Users.AnyAsync(u => u.Username == registerRequest.Username);
// //     if (existingUser)
// //     {
// //         return Results.Conflict("Username already exists.");
// //     }

// //     var hashedPassword = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password);

// //     var newUser = new User
// //     {
// //         Username = registerRequest.Username,
// //         Password = hashedPassword
// //     };

// //     dbContext.Users.Add(newUser);
// //     await dbContext.SaveChangesAsync();

// //     return Results.Ok("User registered successfully.");
// // });

// // // Protected Home Endpoint
// // app.MapGet("/", [Microsoft.AspNetCore.Authorization.Authorize] async (ToDoDbContext dbContext) =>
// // {
// //     var items = await dbContext.Items.ToListAsync();
// //     return Results.Json(items);
// // });

// // // CRUD Operations for Todo Items
// // app.MapGet("/todo", async (ToDoDbContext dbContext) =>
// // {
// //     var items = await dbContext.Items.ToListAsync();
// //     return Results.Json(items);
// // });

// // app.MapPost("/todo",[Microsoft.AspNetCore.Authorization.Authorize] async (ToDoDbContext dbContext, Item newItem) =>
// // {
// //     dbContext.Items.Add(newItem);
// //     await dbContext.SaveChangesAsync();
// //     return Results.Created($"/todo/{newItem.Id}", newItem);
// // });

// // app.MapPut("/todo/{id}",[Microsoft.AspNetCore.Authorization.Authorize] async (int id, ToDoDbContext dbContext, Item updatedItem) =>
// // {
// //     var item = await dbContext.Items.FindAsync(id);
// //     if (item == null)
// //     {
// //         return Results.NotFound("Item not found.");
// //     }

// //     if (!string.IsNullOrEmpty(updatedItem.Name)) item.Name = updatedItem.Name;
// //     item.IsComplete = updatedItem.IsComplete;
// //     await dbContext.SaveChangesAsync();
// //     return Results.Json(item);
// // });

// // app.MapDelete("/todo/{id}", [Microsoft.AspNetCore.Authorization.Authorize] async (int id, ToDoDbContext dbContext) =>
// // {
// //     var item = await dbContext.Items.FindAsync(id);
// //     if (item == null)
// //     {
// //         return Results.NotFound("Item not found.");
// //     }

// //     dbContext.Items.Remove(item);
// //     await dbContext.SaveChangesAsync();
// //     return Results.Ok("Item deleted successfully.");
// // });

// // app.Run();
// using System.IdentityModel.Tokens.Jwt;
// using System.Security.Claims;
// using System.Text;
// using Microsoft.AspNetCore.Authentication.JwtBearer;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.IdentityModel.Tokens;
// using TodoApi;

// var builder = WebApplication.CreateBuilder(args);

// // Add services to the container
// builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// // Add CORS service
// builder.Services.AddCors(options =>
// {
//     options.AddDefaultPolicy(policy =>
//     {
//         policy.AllowAnyOrigin()
//               .AllowAnyMethod()
//               .AllowAnyHeader();
//     });
// });

// // Get the connection string from app configuration
// var connectionString = builder.Configuration.GetConnectionString("ToDoDB");

// if (string.IsNullOrEmpty(connectionString))
// {
//     Console.WriteLine("Connection string is missing!");
//     return;
// }

// builder.Services.AddDbContext<ToDoDbContext>(options =>
//     options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// // Retrieve the JWT Secret key from the configuration
// string secretKey = builder.Configuration["JWT:SecretKey"] ?? throw new ArgumentNullException("JWT:SecretKey is missing");

// // Add JWT Authentication
// var key = Encoding.ASCII.GetBytes(secretKey); // Secret Key
// builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//     .AddJwtBearer(options =>
//     {
//         options.TokenValidationParameters = new TokenValidationParameters
//         {
//             ValidateIssuer = false,
//             ValidateAudience = false,
//             ValidateLifetime = true,
//             ValidateIssuerSigningKey = true,
//             IssuerSigningKey = new SymmetricSecurityKey(key)
//         };
//     });

// // Add Authorization service
// builder.Services.AddAuthorization(); // Add the authorization service

// var app = builder.Build();

// app.UseCors();
// app.UseAuthentication(); // Enable JWT Authentication
// app.UseAuthorization();  // Enable Authorization Middleware

// if (app.Environment.IsDevelopment())
// {
//     app.UseSwagger();
//     app.UseSwaggerUI();
// }

// // Login Endpoint
// app.MapPost("/login", async (User loginRequest, ToDoDbContext dbContext) =>
// {
//     var user = await dbContext.Users.SingleOrDefaultAsync(u => u.Username == loginRequest.Username);
//     if (user == null || !BCrypt.Net.BCrypt.Verify(loginRequest.Password, user.Password))
//     {
//         return Results.Unauthorized();
//     }

//     // Generate JWT
//     var claims = new[]
//     {
//         new Claim(ClaimTypes.Name, user.Username),
//         new Claim("UserId", user.Id.ToString())
//     };

//     var tokenDescriptor = new SecurityTokenDescriptor
//     {
//         Subject = new ClaimsIdentity(claims),
//         Expires = DateTime.UtcNow.AddHours(1),
//         SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
//     };

//     var tokenHandler = new JwtSecurityTokenHandler();
//     var token = tokenHandler.CreateToken(tokenDescriptor);

//     return Results.Json(new { Token = tokenHandler.WriteToken(token) });
// });

// // Register Endpoint
// app.MapPost("/register", async (User registerRequest, ToDoDbContext dbContext) =>
// {
//     if (string.IsNullOrEmpty(registerRequest.Username) || string.IsNullOrEmpty(registerRequest.Password))
//     {
//         return Results.BadRequest("Username and password are required.");
//     }

//     var existingUser = await dbContext.Users.AnyAsync(u => u.Username == registerRequest.Username);
//     if (existingUser)
//     {
//         return Results.Conflict("Username already exists.");
//     }

//     var hashedPassword = BCrypt.Net.BCrypt.HashPassword(registerRequest.Password);

//     var newUser = new User
//     {
//         Username = registerRequest.Username,
//         Password = hashedPassword
//     };

//     dbContext.Users.Add(newUser);
//     await dbContext.SaveChangesAsync();

//     return Results.Ok("User registered successfully.");
// });

// // Protected Home Endpoint
// app.MapGet("/", [Microsoft.AspNetCore.Authorization.Authorize] async (ToDoDbContext dbContext) =>
// {
//     var items = await dbContext.Items.ToListAsync();
//     return Results.Json(items);
// });



// app.MapPost("/", [Microsoft.AspNetCore.Authorization.Authorize] async (ToDoDbContext dbContext, Item newItem) =>
// {
//     System.Console.WriteLine("hi------------------------------------------------------------------------------------------");
//     dbContext.Items.Add(newItem);
//     await dbContext.SaveChangesAsync();
//     return Results.Created($"/{newItem.Id}", newItem);
// });

// app.MapPut("/{id}", [Microsoft.AspNetCore.Authorization.Authorize] async (int id, ToDoDbContext dbContext, Item updatedItem) =>
// {
//     var item = await dbContext.Items.FindAsync(id);
//     if (item == null)
//     {
//         return Results.NotFound("Item not found.");
//     }

//     if (!string.IsNullOrEmpty(updatedItem.Name)) item.Name = updatedItem.Name;
//     item.IsComplete = updatedItem.IsComplete;
//     await dbContext.SaveChangesAsync();
//     return Results.Json(item);
// });

// app.MapDelete("/{id}", [Microsoft.AspNetCore.Authorization.Authorize] async (int id, ToDoDbContext dbContext) =>
// {
//     var item = await dbContext.Items.FindAsync(id);
//     if (item == null)
//     {
//         return Results.NotFound("Item not found.");
//     }

//     dbContext.Items.Remove(item);
//     await dbContext.SaveChangesAsync();
//     return Results.Ok("Item deleted successfully.");
// });

// app.Run();
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using TodoApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS service
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Get the connection string from app configuration
var connectionString = builder.Configuration.GetConnectionString("ToDoDB");

if (string.IsNullOrEmpty(connectionString))
{
    Console.WriteLine("Connection string is missing!");
    return;
}

builder.Services.AddDbContext<ToDoDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Retrieve the JWT Secret key from the configuration
string secretKey = builder.Configuration["JWT:SecretKey"] ?? throw new ArgumentNullException("JWT:SecretKey is missing");

// Add JWT Authentication
var key = Encoding.ASCII.GetBytes(secretKey); // Secret Key
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key)
        };
    });

// Add Authorization service
builder.Services.AddAuthorization();

var app = builder.Build();

app.UseCors();
app.UseAuthentication(); // Enable JWT Authentication
app.UseAuthorization();  // Enable Authorization Middleware

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Route to Get All Tasks
app.MapGet("/", [Microsoft.AspNetCore.Authorization.Authorize] async (ToDoDbContext dbContext) =>
{
    var tasks = await dbContext.Items.ToListAsync();
    return Results.Json(tasks);
});

// Route to Add New Task
app.MapPost("/", [Microsoft.AspNetCore.Authorization.Authorize] async (ToDoDbContext dbContext, Item newItem) =>
{
    dbContext.Items.Add(newItem);
    await dbContext.SaveChangesAsync();
    return Results.Created($"/{newItem.Id}", newItem);
});

// Route to Update a Task
app.MapPut("/{id}", [Microsoft.AspNetCore.Authorization.Authorize] async (int id, ToDoDbContext dbContext, Item updatedItem) =>
{
    var item = await dbContext.Items.FindAsync(id);
    if (item == null)
    {
        return Results.NotFound("Item not found.");
    }

    if (!string.IsNullOrEmpty(updatedItem.Name)) item.Name = updatedItem.Name;
    item.IsComplete = updatedItem.IsComplete;
    await dbContext.SaveChangesAsync();
    return Results.Json(item);
});

// Route to Delete a Task
app.MapDelete("/{id}", [Microsoft.AspNetCore.Authorization.Authorize] async (int id, ToDoDbContext dbContext) =>
{
    var item = await dbContext.Items.FindAsync(id);
    if (item == null)
    {
        return Results.NotFound("Item not found.");
    }

    dbContext.Items.Remove(item);
    await dbContext.SaveChangesAsync();
    return Results.Ok("Item deleted successfully.");
});

app.Run();
