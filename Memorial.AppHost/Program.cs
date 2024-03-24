var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Memorial>("memorial");

builder.Build().Run();
