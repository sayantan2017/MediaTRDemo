using MediatR;
using MediaTRDemo.Model;

namespace MediaTRDemo.Quries
{
    public class GetAllStudentQuery : IRequest<List<StudentDetails>> { }
}
