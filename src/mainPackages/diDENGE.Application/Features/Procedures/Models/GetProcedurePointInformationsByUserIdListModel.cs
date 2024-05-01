using Core.Persistence.Paging;
using diDENGE.Application.Features.Procedures.Dtos;

namespace diDENGE.Application.Features.Procedures.Models;

public class GetProcedurePointInformationsByUserIdListModel: BasePageableModel
{
    public IList<GetProcedurePointInformationsByUserIdListItemDto> Items { get; set; }
}