using System;
using System.Reflection;

namespace PayByPhone.TestAssignment.FoodTrees.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}