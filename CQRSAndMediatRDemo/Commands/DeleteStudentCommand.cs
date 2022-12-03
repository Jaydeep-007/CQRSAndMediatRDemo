using MediatR;

namespace CQRSAndMediatRDemo.Commands
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}

