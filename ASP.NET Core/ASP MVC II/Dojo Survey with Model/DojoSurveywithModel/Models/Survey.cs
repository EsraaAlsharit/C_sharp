//ignore the none value attribute 
#pragma warning disable CS8618

namespace DojoSurveywithModel.Models;

public class Survey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Languge { get; set; }
    public string Comment { get; set; }

}