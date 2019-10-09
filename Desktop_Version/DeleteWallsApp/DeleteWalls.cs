using System;
using System.IO;

using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace DeleteWalls
{
   [Autodesk.Revit.Attributes.Regeneration(Autodesk.Revit.Attributes.RegenerationOption.Manual)]
   [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
   public class DeleteWallsApp : IExternalCommand
   {

      public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
      {
         var app = commandData.Application.Application;
         var doc = commandData.Application.ActiveUIDocument?.Document;
         DeleteAllWalls(app, doc);
         return Result.Succeeded;
      }

      public static void DeleteAllWalls(Application rvtApp, Document doc)
      {
         if (rvtApp == null) throw new InvalidDataException(nameof(rvtApp));

         if (doc == null) throw new InvalidOperationException("Could not open document.");

         using (Transaction transaction = new Transaction(doc))
         {
            FilteredElementCollector col = new FilteredElementCollector(doc).OfClass(typeof(Wall));
            transaction.Start("Delete All Walls");
            doc.Delete(col.ToElementIds());
            transaction.Commit();
         }
      }
   }
}
