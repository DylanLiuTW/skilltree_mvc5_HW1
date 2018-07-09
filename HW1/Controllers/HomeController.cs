using HW1.Enums;
using HW1.Models.Service;
using HW1.Models.ViewModel;
using System.Web.Mvc;

namespace HW1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewData[ "InOutEnumDropDownList" ] = typeof( InOut ).GetEnumSelectListByDescription<InOut>();

            return View();
        }
        /// <summary>
        /// 列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index( InOutViewModel model )
        {
            ViewData[ "InOutEnumDropDownList" ] = typeof( InOut ).GetEnumSelectListByDescription<InOut>();

            return View( new InOutViewModel() );
        }
        /// <summary>
        /// 子列表
        /// </summary>
        /// <returns></returns>
        [ChildActionOnly]
        public ActionResult SubIndex()
        {
            var service = new InOutService();

            return View( service.CreateFakeData( 50 ) );
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}