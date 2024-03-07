using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Library.View
{
    public interface IDepartmentView : IBaseView ,IDataModelEventHandler
    {
        string DepartmentId { get; set; } 
        string DepartmentName { get; set; }
        string? Building { get; set; }
    }
}
