using Microsoft.Extensions.DependencyInjection;
using OrchardCore.Modules;
using OrchardCore.Workflows.Helpers;
using YuSheng.OrchardCore.Workflow.Notify.Feishu.Activities;
using YuSheng.OrchardCore.Workflow.Notify.Feishu.Drivers;

namespace YuSheng.OrchardCore.Workflow.Notify.Feishu
{
    [Feature("YuSheng.OrchardCore.Workflow.Notify.Feishu")]
    public class Startup : StartupBase
    {
        public override void ConfigureServices(IServiceCollection services)
        {

            services.AddActivity<NotifyFeishuTask, NotifyFeishuTaskDisplayDriver>(); ;


        }
    }
}
