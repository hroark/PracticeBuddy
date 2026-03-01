var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.PracticeBuddyAPI>("practicebuddyapi");

builder.Build().Run();
