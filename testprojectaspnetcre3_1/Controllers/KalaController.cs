using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using testprojectaspnetcre3_1.Data;
using testprojectaspnetcre3_1.Models;
using testprojectaspnetcre3_1.Service;

namespace testprojectaspnetcre3_1.Controllers
{
    public class KalaController : Controller
    {
        private readonly IRepositoryKala _rep;
        private readonly IMapper _mapper;
        public KalaController(IRepositoryKala rep, IMapper mapper)
        {
            _rep = rep;
            _mapper = mapper;
        }
        // GET: KalaController
        public ActionResult Index()
        {
            var kala = _rep.FindAll().ToList();
            var model = _mapper.Map<List<Kala>, List<DetailsViewModelKala>>(kala);

            return View(model);
        }

        // GET: KalaController/Details/5
        public ActionResult Details(int id)
        {
            if (!_rep.isExists(id))
            {
                return NotFound();
            }
            var kala = _rep.FindById(id);
            var model = _mapper.Map<DetailsViewModelKala>(kala);


            return View(model);

        }

        // GET: KalaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KalaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateViewModelKala model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var kala = _mapper.Map<Kala>(model);
                var isSuccess = _rep.Create(kala);
                if (!isSuccess)
                {

                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "در ثبت اطلاعات مشکلی به وجود آمده است");
                return View(model);
            }
        }

        // GET: KalaController/Edit/5
        public ActionResult Edit(int id)
        {
            if (!_rep.isExists(id))
            {
                return NotFound();
            }
            var kala = _rep.FindById(id);
            var model = _mapper.Map<DetailsViewModelKala>(kala);


            return View(model);
        }

        // POST: KalaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, DetailsViewModelKala model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var kala = _mapper.Map<Kala>(model);
                var isSuccess = _rep.Update(kala);
                if (!isSuccess)
                {
                    ModelState.AddModelError("", "در ویرایش اطلاعات مشکلی به وجود آمده است");
                    return View(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("", "در ثبت اطلاعات مشکلی به وجود آمده است");
                return View(model);
            }
        }

        // GET: KalaController/Delete/5
        public ActionResult Delete(int id)
        {
            var kala = _rep.FindById(id);
            var isSuccess = _rep.Delete(kala);
            if (!isSuccess)
            {
                return BadRequest();
            }
            return RedirectToAction(nameof(Index));
            //if (!_rep.isExists(id))
            //{
            //    return NotFound();
            //}
            //var kala = _rep.FindById(id);
            //var model = _mapper.Map<DetailsViewModelKala>(kala);


            //return View(model);

        }

        // POST: KalaController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, DetailsViewModelKala model)
        //{
        //    try
        //    {
        //        var kala = _rep.FindById(id);
        //        var isSuccess = _rep.Delete(kala);
        //        if (!isSuccess)
        //        {
        //            return View(model);
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View(model);
        //    }
        //}
    }
}
