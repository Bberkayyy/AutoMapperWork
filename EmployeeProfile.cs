using AutoMapper;

namespace AutoMapperWork.Models;

public class EmployeeProfile:Profile
{
    public EmployeeProfile()
    {
        CreateMap<Employee, EmployeeDTO>().ForMember(d=>d.FullName,o=>o.MapFrom(s=>s.FirstName + " " +s.LastName)).ReverseMap();
    }
}
