using System.Collections.Generic;
using UsingAutoMapper.Models;

namespace UsingAutoMapper.Services.Abstract
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetEmployees();
    }
}