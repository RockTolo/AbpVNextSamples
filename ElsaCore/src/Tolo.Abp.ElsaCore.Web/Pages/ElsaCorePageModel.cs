using Tolo.Abp.ElsaCore.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Tolo.Abp.ElsaCore.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ElsaCorePageModel : AbpPageModel
    {
        protected ElsaCorePageModel()
        {
            LocalizationResourceType = typeof(ElsaCoreResource);
        }
    }
}