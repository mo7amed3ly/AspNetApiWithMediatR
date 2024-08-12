using AspNetApiWithMediatR.Models;
using MediatR;

namespace AspNetApiWithMediatR.Commands;

public record InsertPersonCommand(string FirstName, string LastName):IRequest<Person>;
