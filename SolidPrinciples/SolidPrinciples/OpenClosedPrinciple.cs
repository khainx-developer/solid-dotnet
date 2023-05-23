namespace SolidPrinciples;

public class ReportGeneration
{
    public string ReportType { get; set; }

    // this method has problem that we always modify this method if we add a new condition
    public void GenerateReport()
    {
        if (ReportType == "Excel")
        {
            // Generate Excel report
        }
        else if (ReportType == "PDF")
        {
            // Generate PDF report
        }
        // else if ...
    }
}

// refactor the report class
public class Report
{
    public void GenerateReport()
    {
        // Generate simple report
    }
}

public class ExcelReport
{
    public void GenerateReport()
    {
        // Generate Excel report
    }
}

public class PdfReport
{
    public void GenerateReport()
    {
        // Generate PDF report
    }
}