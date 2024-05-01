namespace diDENGE.Application.Features.Procedures.Dtos;

public class GetProcedurePointInformationsByUserIdListItemDto
{
    public string Id { get; set; }
    public string AddictionLevelId { get; set; }
    
    public GetProcedurePointInformationsByUserIdListItemProcedureDto Procedure { get; set; }
    
    public double OverallGrade { get; set; }

    public int Count { get; set; }

    public DateTime CreatedAt { get; set; }
}

public class GetProcedurePointInformationsByUserIdListItemProcedureDto
{
    public string Id { get; set; }
    public string Name { get; set; }
}