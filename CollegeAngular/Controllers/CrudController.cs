
using System.Web.Mvc;

namespace CollegeAngular.Controllers
{
    public interface ICrudController<in T> 
    {
        JsonResult Get();
        JsonResult Post(T request);
        JsonResult Put(T request);
    }
}