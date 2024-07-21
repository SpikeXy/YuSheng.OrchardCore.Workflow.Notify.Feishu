using System.ComponentModel.DataAnnotations;

namespace YuSheng.OrchardCore.Workflow.Notify.Feishu.ViewModels
{
    public class NotifyFeishuTaskViewModel
    {
        [Required]
        public string Webhook { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
