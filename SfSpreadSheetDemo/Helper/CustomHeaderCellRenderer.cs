using Syncfusion.UI.Xaml.Grid.ScrollAxis;
using Syncfusion.UI.Xaml.Spreadsheet.CellRenderer;
using Syncfusion.UI.Xaml.Spreadsheet;
using System.Windows.Media;
using System.Windows;

namespace SfSpreadSheetDemo
{
    // Custom header cell renderer
    public class CustomHeaderCellRenderer : SpreadsheetHeaderCellRenderer
    {
        // Override the OnRender method
        protected override void OnRender(RowColumnIndex cellRowColumnIndex, DrawingContext dc, Rect cellRect, SpreadsheetColumn column, object textElement)
        {
            // Customize based on your scenario
            if (column.DisplayText == "A")
            {
                // Change the Header Text for A column
                column.DisplayText = "Item Name";
            }

            if (column.DisplayText == "B")
            {
                // Change the Header Text for B column
                column.DisplayText = "Quantity";
            }

            if (column.DisplayText == "C")
            {
                // Change the Header Text for C column
                column.DisplayText = "Price";
            }

            if (column.DisplayText == "D")
            {
                // Change the Header Text for D column
                column.DisplayText = "Amount";
            }

            if (column.DisplayText == "E")
            {
                // Change the Header Text for E column
                column.DisplayText = "Discount";
            }

            if (column.DisplayText == "F")
            {
                // Change the Header Text for F column
                column.DisplayText = "Profit";
            }

            base.OnRender(cellRowColumnIndex, dc, cellRect, column, textElement);
        }
    }
}