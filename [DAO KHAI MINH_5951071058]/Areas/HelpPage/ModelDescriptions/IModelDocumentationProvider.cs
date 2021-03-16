using System;
using System.Reflection;

namespace _DAO_KHAI_MINH_5951071058_.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}