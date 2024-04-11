using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace Revit_API3
{
    [Transaction(TransactionMode.Manual)]
    public class Class1 : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication application)
        {
            TaskDialog.Show("Hello World", "Hello Revit API!");
            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
