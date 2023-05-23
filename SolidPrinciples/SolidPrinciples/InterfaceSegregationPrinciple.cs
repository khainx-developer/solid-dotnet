namespace SolidPrinciples;

public interface IPrinterTasks
{
    void Print(string printContent);
    void Scan(string scanContent);
    void Fax(string faxContent);
    void PrintDuplex(string printDuplexContent);
}

class LiquidInkJetPrinter : IPrinterTasks
{
    public void Print(string printContent)
    {
        Console.WriteLine("Print Done");
    }

    public void Scan(string scanContent)
    {
        Console.WriteLine("Scan content");
    }

    // class LiquidInkJetPrinter does not have this method
    public void Fax(string faxContent)
    {
        throw new NotImplementedException();
    }

    // class LiquidInkJetPrinter does not have this method
    public void PrintDuplex(string printDuplexContent)
    {
        throw new NotImplementedException();
    }
}

// refactor the interface
public interface IPrinterTasksV1
{
    void Print(string printContent);
    void Scan(string scanContent);
}

public interface IFaxTasks
{
    void Fax(string faxContent);
}

public interface IPrintDuplexTasks
{
    void PrintDuplex(string printDuplexContent);
}

class LiquidInkJetPrinterV1 : IPrinterTasksV1
{
    public void Print(string printContent)
    {
        Console.WriteLine("Print Done");
    }

    public void Scan(string scanContent)
    {
        Console.WriteLine("Scan content");
    }
}