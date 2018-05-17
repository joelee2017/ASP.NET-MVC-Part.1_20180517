using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}