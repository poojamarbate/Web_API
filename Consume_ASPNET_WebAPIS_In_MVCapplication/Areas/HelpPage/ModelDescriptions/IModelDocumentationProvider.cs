using System;
using System.Reflection;

namespace Consume_ASPNET_WebAPIS_In_MVCapplication.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}