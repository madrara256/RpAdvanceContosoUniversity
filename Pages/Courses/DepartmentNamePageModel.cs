using ContosoUniversity.Data;
using System;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ContosoUniversity.Pages.Courses
{
    public class DepartmentNamePageModel
    {

        public SelectList DepartmentNameSL { get; set; }

        public void PolpulateDepartmentsDropDownList(SchoolContext _contetx,
            object selectedDepartment = null)
        {
            var departmentsQuery = from d in _contetx.Departments
                                   orderby d.Name //Sort by name.
                                   select d;

            DepartmentNameSL = new SelectList(departmentsQuery.AsNoTracking(),
                "DepartmentID", "Name", selectedDepartment);
        }
    }
}
