using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WorldCupsMvc.Models;
using WorldCupsMvc.Models.Dtos.Country;
using WorldCupsMvc.Services.IServices;

namespace WorldCupsMvc.Controllers
{
    public class CountryController : Controller
    {

        private readonly ICountryService _countryService;
        private readonly IMapper _mapper;

        public CountryController(ICountryService countryService, IMapper mapper)
        {
            _countryService = countryService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            List<GetCountryDto> list = new();
            var response = await _countryService.GetAll<ServiceResponse>();
            if (response != null && response.Success)
            {
                list = JsonConvert.DeserializeObject<List<GetCountryDto>>(Convert.ToString(response.Data));
            }
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AddCountryDto dto)
        {
            if (ModelState.IsValid)
            {
                var response = await _countryService.Create<ServiceResponse>(dto);
                if (response != null && response.Success)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(dto);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var response = await _countryService.GetById<ServiceResponse>(id);
            if (response != null && response.Success)
            {
                UpdateCountryDto dto = JsonConvert.DeserializeObject<UpdateCountryDto>(Convert.ToString(response.Data));
                return View(dto);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateCountryDto dto)
        {
            if (ModelState.IsValid)
            {
                var response = await _countryService.Update<ServiceResponse>(dto);
                if (response != null && response.Success)
                {
                    return RedirectToAction("Index");
                }
            }
            return View(dto);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var response = await _countryService.GetById<ServiceResponse>(id);
            if (response != null && response.Success)
            {
                GetCountryDto dto = JsonConvert.DeserializeObject<GetCountryDto>(Convert.ToString(response.Data));
                return View(dto);
            }
            return NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(GetCountryDto dto)
        {
            var response = await _countryService.Delete<ServiceResponse>(dto.Id);
            if (response != null && response.Success)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }


    }
}