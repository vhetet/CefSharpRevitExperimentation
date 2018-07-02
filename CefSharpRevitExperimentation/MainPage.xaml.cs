using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Autodesk.Revit.UI;

namespace CefSharpRevitExperimentation
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : UserControl, Autodesk.Revit.UI.IDockablePaneProvider
    {
        #region Data
        private Guid m_targetGuid;
        private DockPosition m_position = DockPosition.Bottom;
        private int m_left = 1;
        private int m_right = 1;
        private int m_top = 1;
        private int m_bottom = 1;
        const string _url_tbc = "http://thebuildingcoder.typepad.com";
        const string _url_git = "https://github.com/jeremytammik/DockableDialog";
        #endregion

        public MainPage()
        {
            InitializeComponent();
        }

        public void SetupDockablePane(Autodesk.Revit.UI.DockablePaneProviderData data)
        {
            data.FrameworkElement = this as FrameworkElement;
            data.InitialState = new Autodesk.Revit.UI.DockablePaneState();
            data.InitialState.DockPosition = DockPosition.Tabbed;
            //DockablePaneId targetPane;
            //if (m_targetGuid == Guid.Empty)
            //    targetPane = null;
            //else targetPane = new DockablePaneId(m_targetGuid);
            //if (m_position == DockPosition.Tabbed)
            data.InitialState.TabBehind = Autodesk.Revit.UI.DockablePanes.BuiltInDockablePanes.ProjectBrowser;
            //if (m_position == DockPosition.Floating)
            //{
            //data.InitialState.SetFloatingRectangle(new Autodesk.Revit.UI.Rectangle(10, 710, 10, 710));
            //data.InitialState.DockPosition = DockPosition.Tabbed;
            //}
            //Log.Message("***Intial docking parameters***");
            //Log.Message(APIUtility.GetDockStateSummary(data.InitialState));
        }

        public void SetInitialDockingParameters(int left, int right, int top, int bottom, DockPosition position, Guid targetGuid)
        {
            m_position = position;
            m_left = left;
            m_right = right;
            m_top = top;
            m_bottom = bottom;
            m_targetGuid = targetGuid;
        }

        private void DockableDialogs_Loaded(
            object sender,
            RoutedEventArgs e)
        {

        }
    }
}
