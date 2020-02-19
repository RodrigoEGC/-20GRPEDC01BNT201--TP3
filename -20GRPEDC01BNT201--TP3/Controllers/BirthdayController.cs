using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20GRPEDC01BNT201__TP3.Models;
using _20GRPEDC01BNT201__TP3.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _20GRPEDC01BNT201__TP3.Controllers
{
    public class BirthdayController : Controller
    {
        private readonly BirthdayRepository _birthdayRepository;

        public BirthdayController()
        {
            _birthdayRepository = new BirthdayRepository();
        }
        // GET: Birthday
        public ActionResult Index()
        {
            return View(_birthdayRepository.GetAll());
        }

        // GET: Birthday/Details/5
        public ActionResult Details(int id)
        {
            var birthday = _birthdayRepository.GetById(id);
            return View(birthday);
        }

        // GET: Birthday/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Birthday/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BirthdayModel createBirthdayModel)
        {
            try
            {
                // TODO: Add insert logic here

                _birthdayRepository.Add(createBirthdayModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Birthday/Edit/5
        public ActionResult Edit(int id)
        {
            var birthday = _birthdayRepository.GetById(id);
            return View(birthday);
        }

        // POST: Birthday/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(BirthdayModel editBirthdayModel)
        {
            try
            {
                // TODO: Add update logic here
                _birthdayRepository.Update(editBirthdayModel);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Birthday/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Birthday/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(BirthdayModel birthdayModel)
        {
            try
            {
                // TODO: Add delete logic here

                _birthdayRepository.Remove(birthdayModel.Id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}