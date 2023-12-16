using MediatR;
using MediaTRDemo.Model;

namespace MediaTRDemo.Quries
{
    public class GetStudentByIdQuery : IRequest<StudentDetails>
    {
        public int Id { get; set; }
    }
}
