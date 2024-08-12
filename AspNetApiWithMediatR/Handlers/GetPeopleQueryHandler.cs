using AspNetApiWithMediatR.DataAccess;
using AspNetApiWithMediatR.Models;
using AspNetApiWithMediatR.Queries;
using FluentResults;
using MediatR;

namespace AspNetApiWithMediatR.Handlers
{
    public class GetPeopleQueryHandler : IRequestHandler<GetPeopleQuery, Result<List<Person>>>
    {
        private readonly IDataAccess _dataAccess;

        public GetPeopleQueryHandler(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public Task<Result<List<Person>>> Handle(GetPeopleQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Result.Fail<List<Person>>(new[]{ "Some Error", "Another error" }));
            return Task.FromResult(Result.Ok(_dataAccess.GetPeople()));
        }
    }
}
