using MediatR;
using Microsoft.AspNetCore.Http;
using Resume.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resume.Application.UseCases.Resume.Commands
{
    public class UploadResumeCommand : IRequest<ResponseModel>
    {
        public Guid UserId { get; set; }
        public IFormFile Document { get; set; }
        public string Token { get; set; }
    }
}
