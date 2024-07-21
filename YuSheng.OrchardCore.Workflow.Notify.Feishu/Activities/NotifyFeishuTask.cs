using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Localization;
using OrchardCore.Workflows.Abstractions.Models;
using OrchardCore.Workflows.Activities;
using OrchardCore.Workflows.Models;
using OrchardCore.Workflows.Services;
using Python.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace YuSheng.OrchardCore.Workflow.Notify.Feishu.Activities
{
    public class NotifyFeishuTask : TaskActivity
    {
        private readonly IWorkflowScriptEvaluator _scriptEvaluator;
        private readonly IStringLocalizer S;
        private readonly IHtmlHelper _htmlHelper;
        private readonly IWorkflowExpressionEvaluator _expressionEvaluator;
        public NotifyFeishuTask(IWorkflowScriptEvaluator scriptEvaluator,
            IWorkflowExpressionEvaluator expressionEvaluator,
            IHtmlHelper htmlHelper,
            IStringLocalizer<NotifyFeishuTask> localizer)
        {
            _scriptEvaluator = scriptEvaluator;
            _expressionEvaluator = expressionEvaluator;
            S = localizer;
            _htmlHelper = htmlHelper;

        }

        public override string Name => nameof(NotifyFeishuTask);

        public override LocalizedString DisplayText => S["Notify Feishu Task"];

        public override LocalizedString Category => S["Notify"];

        public WorkflowExpression<string> Webhook
        {
            get => GetProperty(() => new WorkflowExpression<string>());
            set => SetProperty(value);
        }

        public WorkflowExpression<object> Message
        {
            get => GetProperty(() => new WorkflowExpression<object>());
            set => SetProperty(value);
        }

        public override IEnumerable<Outcome> GetPossibleOutcomes(WorkflowExecutionContext workflowContext, ActivityContext activityContext)
        {
            return Outcomes(S["Done"]);
        }

        public override async Task<ActivityExecutionResult> ExecuteAsync(WorkflowExecutionContext workflowContext, ActivityContext activityContext)
        {

            var webhook = Webhook.Expression;
            var message = Message.Expression;



            return Outcomes("Done");
        }
    }
}
