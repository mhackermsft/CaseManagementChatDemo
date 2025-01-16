using Aspire.Hosting;

var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.CaseManagementAPI>("casemanagementapi");
builder.AddProject<Projects.CaseManagementChatDemo>("casemanagementchatdemo")
    .WithReference(api);
builder.Build().Run();
