using Diary_App.Data;
using Diary_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Diary_App.Controllers
{
    public class DiaryEntryController : Controller
    {
        private readonly CLSDbContext db;
        public DiaryEntryController(CLSDbContext db) 
        {
           this.db = db; 
        }
        public IActionResult Index()
        {
            List<DiaryEntry> listeEntries =db.DiaryEntries.ToList();
            return View(listeEntries);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(DiaryEntry obj)
        {
            if(ModelState.IsValid )
            {
                db.DiaryEntries.Add(obj);
                db.SaveChanges();
                TempData["success"] = "the has been Create successfully";
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int Id)
        {
            DiaryEntry? obj = db.DiaryEntries.FirstOrDefault(x => x.Id == Id);
            if(obj == null)
            {
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(DiaryEntry entry)
        {
            if(ModelState.IsValid)
            {
                db.DiaryEntries.Update(entry);
                db.SaveChanges();
                TempData["success"] = "the has been edit successfully";
                return RedirectToAction("Index");
            }
            return View(entry);
        }
        public IActionResult Delete(int Id)
        {
            DiaryEntry? entry = db.DiaryEntries.FirstOrDefault(u=>u.Id == Id);
            if(entry == null)
            {
                return RedirectToAction("Index");
            }
            return View(entry);
        }
        [HttpPost]
        public IActionResult Delete(DiaryEntry entry)     {
            if (ModelState.IsValid)
            {
                db.DiaryEntries.Remove(entry);
                db.SaveChanges();
                TempData["success"] = "the has been delete successfully";
                    return RedirectToAction("Index");
            }
            return View(entry);
        }
    }
}
