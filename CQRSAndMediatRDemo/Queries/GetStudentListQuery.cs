using CQRSAndMediatRDemo.Models;
using MediatR;

namespace CQRSAndMediatRDemo.Queries
{
    public class GetStudentListQuery :  IRequest<List<StudentDetails>>
    {
    }
}
