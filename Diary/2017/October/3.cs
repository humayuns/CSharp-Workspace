// Auto print without dialog
// https://stackoverflow.com/questions/17590896/auto-print-without-dialog


//Instead of the PrintDialog class, try using the PrintDocument class directly, where you can set the printer by the name:

using System.Drawing.Printing;

PrintDocument pd = new PrintDocument();
pd.PrinterSettings.PrinterName = "my printer";


//To loop through the available printer names:

foreach (string s in PrinterSettings.InstalledPrinters) {
  //
}