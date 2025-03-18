namespace Mvc_train.Models
{
    public class ErrorViewModel
    {
        //ErrorViewModel
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
