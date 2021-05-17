#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Autodesk.Revit.DB.Architecture;
using View = Autodesk.Revit.DB.View;

#endregion

namespace Kursach
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        
        public Result Execute(
            ExternalCommandData commandData,
            ref string message,
            ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Autodesk.Revit.ApplicationServices.Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // Access current selection
            Selection sel = uidoc.Selection;

            try
            {
                List<Room> RoomList = Utils.getAllRooms(doc);
                App.thisApp.ShowForm(commandData.Application, RoomList);

                return Result.Succeeded;
            }
            catch (Exception e)
            {
                TaskDialog.Show("Revit", e.Message + e.StackTrace);
                return Result.Cancelled;
            }
        }


        
    }

}
