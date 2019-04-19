using System.Collections.Generic;
using System.Text;
using Kendo.Mvc.UI;

namespace Academy.Application.Courses
{
    //TODO: use adapter pattern
    public interface ICourseService
    {
        DataSourceResult Get(DataSourceRequest request);
    }
}
