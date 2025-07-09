using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using PluginRvt;
using System.Windows;

[Transaction(TransactionMode.Manual)]

public class ExternalCommand : IExternalCommand
{
    private ExternalCommandData commandData;

    public Result Execute(ExternalCommandData commnandData, ref string message, ElementSet elements)
    {

        var ui = new MainWindow(commandData);
        ui.ShowDialog();

        return Result.Succeeded;

    }

}