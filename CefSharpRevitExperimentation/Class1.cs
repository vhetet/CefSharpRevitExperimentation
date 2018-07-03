using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Events;


namespace CefSharpRevitExperimentation
{
    /// <summary>
    /// Register your dockable dialog
    /// </summary>
    [Transaction(TransactionMode.Manual)]
    public class Class1
        : IExternalCommand
    {

        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
//            Process.Start(@"C:\Users\Vincent\source\repos\usg-tech-feasibility-pocs\webkit-addin-poc\web\sample001.rvt");
//            UIDocument test = new UIDocument(new Document());
            commandData.Application.OpenAndActivateDocument(@"C:\Users\Vincent\source\repos\usg-tech-feasibility-pocs\webkit-addin-poc\web\sample001.rvt");
            return Result.Succeeded;
        }
    }
}
