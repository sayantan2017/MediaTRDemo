using MediatR;
using MediaTRDemo.Model;
using MediaTRDemo.Quries;
using MediaTRDemo.Repositories;

namespace MediaTRDemo.Handler
{
    public class GetStudentListHandler : IRequestHandler<GetAllStudentQuery, List<StudentDetails>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentListHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentDetails>> Handle(GetAllStudentQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentListAsync();
        }
    }
}
