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

            string IdList = "danh sach phan tu cua doi tuong: \n ";
            foreach (ElementId e1 in selectElements)
            {
                IdList = IdList + e1.ToString() + "\n";
            }
            MessageBox.Show(IdList);

            XYZ p1 = uidoc.Selection.PickPoint();
            XYZ p2 = uidoc.Selection.PickPoint();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(p1.ToString());
            sb.AppendLine(p2.ToString());

            MessageBox.Show("ban da chon cac diem: " + sb.ToString());

            return Result.Succeeded;
        }
    }
}
