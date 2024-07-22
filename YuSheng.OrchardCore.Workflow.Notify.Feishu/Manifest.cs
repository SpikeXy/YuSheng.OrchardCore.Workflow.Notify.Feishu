using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "YuSheng OrchardCore Workflow Notify Feishu",
    Author = "spike",
    Website = "",
    Version = "0.0.2"
)]

[assembly: Feature(
    Id = "YuSheng.OrchardCore.Workflow.Notify.Feishu",
    Name = "YuSheng OrchardCore Workflow Notify Feishu",
    Description = "Provides Notify Feishu ",
    Dependencies = new[] { "OrchardCore.Workflows" },
    Category = "Workflows"
)]
