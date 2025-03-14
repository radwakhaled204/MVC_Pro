namespace Mvc_train.Models
{
    public class ErrorViewModel
    { //error model
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
