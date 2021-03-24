using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DoAn1_QuanLyThuVien.Models;

namespace DoAn1_QuanLyThuVien.Controllers
{
    public class SachController : Controller
    {
        QuanLyThuVienEntities database = new QuanLyThuVienEntities();
        // GET: Sach
        public ActionResult Index()
        {
            return View(database.Saches.ToList());
        }

        //Tạo mới sách
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Sach sach)
        {
            database.Saches.Add(sach);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        //Xem Chi tiết sách        
        public ActionResult Details(int id)
        {
            return View(database.Saches.Where(a => a.MaSach == id).FirstOrDefault());
           
            
        }
    }
}