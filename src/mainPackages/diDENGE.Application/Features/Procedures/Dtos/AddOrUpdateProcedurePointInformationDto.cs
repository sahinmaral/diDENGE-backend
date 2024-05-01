namespace diDENGE.Application.Features.Procedures.Dtos;

public class AddOrUpdateProcedurePointInformationDto
{
    public string Id { get; set; }
    public string AddictionLevelId { get; set; }
    public double OverallGrade { get; set; }

    public AddOrUpdateProcedurePointInformationProcedureDto Procedure { get; set; }

    public int Count { get; set; }
}

public class AddOrUpdateProcedurePointInformationProcedureDto
{
    public string Id { get; set; }
    public string Name { get; set; }
}