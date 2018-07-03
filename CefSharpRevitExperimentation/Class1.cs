using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        MainPage m_MyDockableWindow = null;

        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            DockablePaneProviderData data
                = new DockablePaneProviderData();

            MainPage MainDockableWindow = new MainPage();

            m_MyDockableWindow = MainDockableWindow;

            data.FrameworkElement = MainDockableWindow
                as System.Windows.FrameworkElement;

            data.InitialState = new DockablePaneState();

            data.InitialState.DockPosition
                = DockPosition.Right;

            data.InitialState.TabBehind = DockablePanes
                .BuiltInDockablePanes.ProjectBrowser;

            DockablePaneId dpid = new DockablePaneId(
                new Guid("{D7C963CE-B7CA-426A-8D51-6E8254D21157}"));

            commandData.Application.RegisterDockablePane(
                dpid, "AEC Dockable Window", MainDockableWindow
                    as IDockablePaneProvider);

            commandData.Application.ViewActivated
                += new EventHandler<ViewActivatedEventArgs>(
                    Application_ViewActivated);

            return Result.Succeeded;
        }

        void Application_ViewActivated(
            object sender,
            ViewActivatedEventArgs e)
        {
//            m_MyDockableWindow.lblProjectName.Content
//                = e.Document.ProjectInformation.Name;
        }
    }
}
