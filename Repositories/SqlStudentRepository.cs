using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.DataModel;

namespace StudentAdminPortal.API.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentAdminContext studentAdminContext;

        public SqlStudentRepository(StudentAdminContext studentAdminContext)
        {
            this.studentAdminContext = studentAdminContext;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await studentAdminContext.Student.ToListAsync();
        }
    }
}
