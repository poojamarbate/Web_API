using System;
using System.Reflection;

namespace SQL_Server_API_using_DBFirst_approach.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}