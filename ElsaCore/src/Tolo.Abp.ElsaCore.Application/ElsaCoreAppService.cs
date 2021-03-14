using System;
using System.Collections.Generic;
using System.Text;
using Tolo.Abp.ElsaCore.Localization;
using Volo.Abp.Application.Services;

namespace Tolo.Abp.ElsaCore
{
    /* Inherit your application services from this class.
     */
    public abstract class ElsaCoreAppService : ApplicationService
    {
        protected ElsaCoreAppService()
        {
            LocalizationResource = typeof(ElsaCoreResource);
        }
    }
}
