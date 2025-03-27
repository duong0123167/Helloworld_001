using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows.Forms;

namespace Helloworld_001
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;

            ICollection<ElementId> selectElements = uidoc.Selection.GetElementIds();

            int totalCount = selectElements.Count;
            MessageBox.Show(" ban da chon " + totalCount.ToString() + " elements");
            return Result.Succeeded;
        }
    }
}
