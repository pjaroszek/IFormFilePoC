using MediatR;
using Microsoft.AspNetCore.Http;


namespace Jaroszek.CoderHouse.IFormFilePoC.Application.FileOperations.Commands;

public record UploadFileCommand(IFormFile File): IRequest;