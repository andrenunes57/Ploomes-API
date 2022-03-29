using PloomesApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace PloomesApi.SwaggerExamples.Requests
{
    public class EmployeeExample : IExamplesProvider<Employee>
    {
        public Employee GetExamples()
        {
            return new Employee
            {
                Id = 0,
                Name = "Some Name",
                Email = "some_email@email.com",
                Age = 28
            };
        }
    }
}
