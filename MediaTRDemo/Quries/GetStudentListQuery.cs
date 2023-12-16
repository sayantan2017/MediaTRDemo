using MediatR;
using MediaTRDemo.Model;

namespace MediaTRDemo.Quries
{
    internal class GetStudentListQuery : IRequest<List<StudentDetails>>
    {
    }
}