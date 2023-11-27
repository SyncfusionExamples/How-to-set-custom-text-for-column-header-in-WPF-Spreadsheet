using Microsoft.Xaml.Behaviors;
using Syncfusion.UI.Xaml.Spreadsheet;
using Syncfusion.UI.Xaml.Spreadsheet.Helpers;

namespace SfSpreadSheetDemo
{
    public class SfSpreadsheetBehavior : Behavior<SfSpreadsheet>
    {
        protected override void OnAttached()
        {
            base.OnAttached();
            // Load the sample excel file in SfSpreadsheet
            AssociatedObject.Open(@"../../../Sample.xlsx");
            // Event subscription
            AssociatedObject.WorkbookLoaded += OnWorkbookLoaded;
        }

        // Event customization
        private void OnWorkbookLoaded(object sender, WorkbookLoadedEventArgs args)
        {
            // Remove the default header cell renderer
            AssociatedObject.ActiveGrid.CellRenderers.Remove("Header");
            // Add the custom header cell renderer
            AssociatedObject.ActiveGrid.CellRenderers.Add("Header", new CustomHeaderCellRenderer());
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            this.AssociatedObject.WorkbookLoaded -= OnWorkbookLoaded;
        }
    }
}