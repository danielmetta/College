
using System.Web.Mvc;

namespace College.Controllers
{
    public interface ICrudController<in T> 
    {
        JsonResult Get();
        JsonResult Post(T request);
        JsonResult Put(T request);
    }
}