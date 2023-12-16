using MediatR;

namespace MediaTRDemo.Command
{
    public class DeleteStudentCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
