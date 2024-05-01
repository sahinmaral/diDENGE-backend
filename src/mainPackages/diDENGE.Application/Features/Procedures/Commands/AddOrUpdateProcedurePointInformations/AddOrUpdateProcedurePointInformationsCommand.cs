using AutoMapper;
using Core.CrossCuttingConcerns.Exceptions;
using diDENGE.Application.Features.Procedures.Dtos;
using diDENGE.Application.Features.Procedures.Models;
using diDENGE.Application.Services.Repositories;
using diDENGE.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace diDENGE.Application.Features.Procedures.Commands.AddOrUpdateProcedurePointInformations;

public class AddOrUpdateProcedurePointInformationsCommand : IRequest<GetProcedurePointInformationsByUserIdListModel>
{
    public string UserId { get; set; }

    public List<AddOrUpdateProcedurePointInformationDto> ProcedurePointInformations { get; set; } =
        new List<AddOrUpdateProcedurePointInformationDto>();
    
    public class
        AddOrUpdateProcedurePointInformationsCommandHandler(
            IProcedurePointInformationRepository procedurePointInformationRepository,
            IProcedureRepository procedureRepository,
            IUserAddictionLevelRepository userAddictionLevelRepository,
            IMapper mapper) : IRequestHandler<
        AddOrUpdateProcedurePointInformationsCommand,GetProcedurePointInformationsByUserIdListModel>
    {
        public async Task<GetProcedurePointInformationsByUserIdListModel> Handle(AddOrUpdateProcedurePointInformationsCommand request, CancellationToken cancellationToken)
        {

            var userAddictionLevel =
                await userAddictionLevelRepository.GetAsync(predicate: queryable => queryable.UserId == request.UserId);

            if (userAddictionLevel is null)
            {
                throw new EntityNotFoundException("User's addiction level does not found");
            }
            
            if (request.ProcedurePointInformations.Count == 0)
            {
                var procedures = await procedureRepository.GetListAsync(size:3, cancellationToken: cancellationToken);
                
                var tasks = procedures.Items.Select(procedure =>
                {
                    var procedurePointInformation = new ProcedurePointInformation
                    {
                        UserId = request.UserId,
                        AddictionLevelId = userAddictionLevel.Id,
                        ProcedureId = procedure.Id,
                        OverallGrade = 0,
                        Count = 0
                    };
                
                    return procedurePointInformationRepository.AddAsync(procedurePointInformation);
                }).ToArray();
                
                await Task.WhenAll(tasks);
            }
            else
            {
                foreach (var addOrUpdateProcedurePointInformationDto in request.ProcedurePointInformations)
                {
                    var procedureFromDatabase = await procedurePointInformationRepository
                        .GetAsync(predicate: queryable => queryable.Id == addOrUpdateProcedurePointInformationDto.Id);
                    procedureFromDatabase.OverallGrade = addOrUpdateProcedurePointInformationDto.OverallGrade;
                    procedureFromDatabase.Count = addOrUpdateProcedurePointInformationDto.Count;
                
                    await procedurePointInformationRepository.UpdateAsync(procedureFromDatabase);
                }
            }

            var addedProcedurePointInformations = await procedurePointInformationRepository.GetListAsync(
                predicate: queryable => queryable.UserId == request.UserId,
                include: queryable => queryable.Include(information => information.Procedure),
                size: 15,
                cancellationToken: cancellationToken);
            return mapper.Map<GetProcedurePointInformationsByUserIdListModel>(addedProcedurePointInformations);
        }
    }
}