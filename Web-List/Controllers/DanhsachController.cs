using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Web_List.Models;

namespace Web_List.Controllers
{
    public class DanhsachController : Controller
    {
        List<SanPham> listSP = new List<SanPham>();
        public IActionResult Giaodien()
        {
            return View(listSP);
        }

        public IActionResult ThemVaoGioHang(SanPham sanphammoi)
        {
            listSP.Add(sanphammoi);

            int tongtien = 0;
            for (int i = 0; i < listSP.Count; i++)
            {
                tongtien = tongtien + (listSP[i].soluong * listSP[i].dongiaban);
            }
            ViewData["Tongtien"] = tongtien;
            return View("Giaodien", listSP);
        }
    }
}
