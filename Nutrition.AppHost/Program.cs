var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer("sql")
                 .AddDatabase("nutritiondatabase");

var apiService = builder.AddProject<Projects.Nutrition_ApiService>("apiservice")
    .WithReference(sql);

builder.AddProject<Projects.Nutrition_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
