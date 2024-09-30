var builder = DistributedApplication.CreateBuilder(args);
var productApi = builder.AddProject<Projects.Ecommerce_ProductService>("productservice-api");
var orderApi = builder.AddProject<Projects.Ecommerce_OrderService>("orderservice-api");

// Add frontend
builder.AddProject<Projects.Ecommerce_Web>("webfrontend")
    .WithReference(productApi)
    .WithReference(orderApi);

builder.Build().Run();
