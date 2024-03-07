using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeManagement.Library.View
{
    public interface IDataModelEventHandler
    {
        event EventHandler? SearchEvent;
        event EventHandler? AddNewEvent;
        event EventHandler? EditEvent;
        event EventHandler? DeleteEvent;
        event EventHandler? SaveEvent;
        event EventHandler? CancelEvent;
    }
}
