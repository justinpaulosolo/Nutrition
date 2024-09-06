var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Nutrition_ApiService>("apiservice");

builder.AddProject<Projects.Nutrition_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
