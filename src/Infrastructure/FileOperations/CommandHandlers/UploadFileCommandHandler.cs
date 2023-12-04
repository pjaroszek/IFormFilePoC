using Jaroszek.CoderHouse.IFormFilePoC.Application.FileOperations.Commands;
using MediatR;

namespace Jaroszek.CoderHouse.IFormFilePoC.Infrastructure.FileOperations.CommandHandlers;

internal sealed class UploadFileCommandHandler: IRequestHandler<UploadFileCommand>
{
    public Task Handle(UploadFileCommand request, CancellationToken cancellationToken)
    {
        Console.WriteLine(request.File.FileName);
      return Task.CompletedTask;
    }
}