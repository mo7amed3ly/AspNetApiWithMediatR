using AspNetApiWithMediatR.Models;
using FluentResults;
using MediatR;
namespace AspNetApiWithMediatR.Queries;
public record GetPeopleQuery() : IRequest<Result<List<Person>>>;

