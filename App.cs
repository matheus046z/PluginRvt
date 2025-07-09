using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace PluginRvt
{
    public class App : IExternalApplication

    {
        public Result OnStartup(UIControlledApplication application)
        {
            string tabName = "Furar Laje";
            try { application.CreateRibbonTab(tabName); } catch { }
        

            RibbonPanel panel = application.CreateRibbonPanel(tabName, "Furos");

            string assemblyPath = Assembly.GetExecutingAssembly().Location;

            PushButtonData buttonData = new PushButtonData(
                "PluginRvt",
                "Furar",
                assemblyPath,
                "PluginRvt.ExternalCommand"
                );

            PushButton pushButton = panel.AddItem(buttonData) as PushButton;

            pushButton.ToolTip = "Plugin criado por Matheus Santana";

            return Result.Succeeded;

        }

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

    }

}