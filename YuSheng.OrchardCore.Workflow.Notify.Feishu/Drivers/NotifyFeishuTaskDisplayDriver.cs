using OrchardCore.Workflows.Display;
using OrchardCore.Workflows.Models;
using YuSheng.OrchardCore.Workflow.Notify.Feishu.Activities;
using YuSheng.OrchardCore.Workflow.Notify.Feishu.ViewModels;

namespace YuSheng.OrchardCore.Workflow.Notify.Feishu.Drivers
{
    public class NotifyFeishuTaskDisplayDriver : ActivityDisplayDriver<NotifyFeishuTask, NotifyFeishuTaskViewModel>
    {
        protected override void EditActivity(NotifyFeishuTask source, NotifyFeishuTaskViewModel model)
        {
            model.Webhook = source.Webhook.Expression;
            model.Message = source.Message.Expression;
        }

        protected override void UpdateActivity(NotifyFeishuTaskViewModel model, NotifyFeishuTask activity)
        {
            activity.Webhook = new WorkflowExpression<string>(model.Webhook);
            activity.Message = new WorkflowExpression<object>(model.Message);
        }
    }
}
