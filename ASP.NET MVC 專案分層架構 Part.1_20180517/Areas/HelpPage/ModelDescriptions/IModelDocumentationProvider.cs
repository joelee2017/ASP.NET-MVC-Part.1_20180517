using System;
using System.Reflection;

namespace ASP.NET_MVC_專案分層架構_Part._1_20180517.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}