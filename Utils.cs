using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Autodesk.Revit.DB;
using Autodesk.Revit.DB.Architecture;
using Autodesk.Revit.DB.Mechanical;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace Kursach
{
    public static class Utils
    {
        public static Room GetRoomByName(List<Room> roomList, string roomName)
        {
            List<string> roomNames = GetRoomNames(roomList);
            Room[] roomArray = roomList.ToArray();
            string[] roomNamesArray = roomNames.ToArray();
            foreach (var room in roomList)
            {
                if (room.Name == roomName)
                {
                    return room;
                }
            }

            throw new Exception();
        }

        public static List<string> GetRoomNames<T>(List<T> roomList) where T : Room
        {
            return (from Room room in roomList select room.Name).ToList();
        }

        public static List<Room> getAllRooms(Document document)
        {
            List<Element> rooms = new FilteredElementCollector(document).OfClass(
                typeof(SpatialElement)).WhereElementIsNotElementType().Where(
                room => room.GetType() == typeof(Room)).ToList();
            return new List<Room>(rooms.Select(r => r as Room));
        }

        public static IList<IList<BoundarySegment>> GetFurniture(Room room)
        {
            BoundingBoxXYZ bb = room.get_BoundingBox(null);
            Outline outline = new Outline(bb.Min, bb.Max);
            bb.Transform.ScaleBasis(1.2);
            BoundingBoxIntersectsFilter filter
                = new BoundingBoxIntersectsFilter(outline);

            Document doc = room.Document;

            // Todo: add category filters and other
            // properties to narrow down the results

            FilteredElementCollector collector
                = new FilteredElementCollector(doc)
                    .OfClass(typeof(FamilyInstance))
                    .WhereElementIsElementType()

                    .WherePasses(filter);

            string roomname = room.Name;

            //List<Element> result = new List<Element>();

            //foreach (FamilyInstance fi in collector)
            //{
            //    result.Add(fi);
            //}

            var result = room.GetBoundarySegments(new SpatialElementBoundaryOptions());
            return result;
        }



        public static List<Wall> GetWallsInRoom(Room room)
        {
            SpatialElementBoundaryOptions options = new SpatialElementBoundaryOptions();
            options.SpatialElementBoundaryLocation = SpatialElementBoundaryLocation.Finish;
            List<Wall> result = new List<Wall>();
            foreach (IList<BoundarySegment> boundSegList in room.GetBoundarySegments(options))
            {
                foreach (BoundarySegment boundSeg in boundSegList)
                {
                    ElementId elem = boundSeg.ElementId;
                    Document doc = room.Document;
                    Element e = doc.GetElement(elem);
                    Wall wall = e as Wall;
                    try
                    {
                        LocationCurve locationCurve = wall?.Location as LocationCurve;
                        Curve curve = locationCurve?.Curve;
                        result.Add((Wall) e);
                    }
                    catch (Exception exception)
                    {
                        TaskDialog.Show("Revit Exception", "Неверно создана комната или стена");
                        throw;
                    }
                }
            }

            return result;

        }

        public static ElementId GetPickedElement(Room room)
        {
            try
            {
                ElementId elementId = null;
                Document doc = room.Document;
                UIDocument uidoc = new UIDocument(doc);
                elementId = uidoc.Selection
                    .PickObject(ObjectType.Element, "Выберите необходимый " +
                                                    "вам элемент или нажмите ESC").ElementId;
                Element elem = doc.GetElement(elementId);
                return elementId;
            }
            catch (Exception e)
            {
                TaskDialog.Show("Revit", $"{e.Message}");
                return null;
            }
        }
        
    }
}
