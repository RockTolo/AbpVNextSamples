using Tolo.Abp.ElsaCore.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Tolo.Abp.ElsaCore.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ElsaCoreController : AbpController
    {
        protected ElsaCoreController()
        {
            LocalizationResource = typeof(ElsaCoreResource);
        }
    }
}