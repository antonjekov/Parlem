namespace Parlem.Web.ViewModels.Shared
{
    using System.ComponentModel.DataAnnotations;

    public class DocNumInputModel
    {
        [Required(ErrorMessage = "Please select document number.")]
        public string DocNum { get; set; }
    }
}
