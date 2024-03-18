using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.WebApp.Controllers
{
    public class GenericController<T, TReadViewModel, TWriteViewModel> : Controller where T : BaseClass where TReadViewModel : IReadViewModel where TWriteViewModel : IWriteViewModel
    {
        private readonly IReadRepository<T> _readRepository;
        private readonly IWriteRepository<T> _writeRepository;
        private readonly IMapper _mapper;
        private readonly IFillEntityRelationshipsService _fillEntityRelationshipsService;

        public GenericController(
            IReadRepository<T> readRepository,
            IWriteRepository<T> writeRepository,
            IMapper mapper,
            IFillEntityRelationshipsService fillEntityRelationshipsService)
        {
            _readRepository = readRepository;
            _writeRepository = writeRepository;
            _mapper = mapper;
            _fillEntityRelationshipsService = fillEntityRelationshipsService;
        }

        [HttpGet]
        public virtual IActionResult Get()
        {
            var entities = _readRepository.GetAllActives().ToList();
            List<TReadViewModel> readViewModelList = _mapper.Map<List<TReadViewModel>>(entities);
            return View(readViewModelList);
        }
        [HttpGet]
        public virtual IActionResult GetPassives()
        {
            var entities = _readRepository.GetAllPassives().ToList();
            List<TReadViewModel> readViewModelList = _mapper.Map<List<TReadViewModel>>(entities);
            return View(readViewModelList);
        }

        [HttpGet("{Area}/{Controller}/{Action}/{id}")]
        public virtual async Task<IActionResult> GetById(string id, List<T>? entities)
        {
            List<TReadViewModel> readViewModelList = _mapper.Map<List<TReadViewModel>>(entities);
            return View(readViewModelList);
        }

        [HttpGet("{Area}/{Controller}/{Action}/{userName}")]
        public virtual async Task<IActionResult> GetByUsername(string userName, List<T>? entities)
        {
            List<TReadViewModel> readViewModelList = _mapper.Map<List<TReadViewModel>>(entities);
            return View(readViewModelList);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Details(Guid id)
        {
            ViewData["CommonColumnTitles"] = new List<string> { "Oluşturma Zamanı", "Oluşturulan Bilgisayar Adı", "Oluşturulan IP Adresi", "Güncelleme Zamanı", "Güncellenilen Bilgisayar Adı", "Güncellenilen IP Adresi" };
            ViewData["CommonProperties"] = new List<string> { "CreatedDate", "CreatedComputerName", "CreatedIpAddress", "UpdatedDate", "UpdatedComputerName", "UpdatedIpAddress" };

            var entity = await _readRepository.GetAllActivesByIdAsync(id);
            TReadViewModel readViewModel = _mapper.Map<TReadViewModel>(entity);
            return View(readViewModel);
        }

        [HttpGet]
        public virtual IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Add(TWriteViewModel modelVM)
        {
            if (ModelState.IsValid)
            {
                T entity = _mapper.Map<T>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _writeRepository.AddAsync(entity);
                if (result)
                {
                    await _writeRepository.SaveChangesAsync();
                    TempData["Success"] = "Ekleme İşlemi Başarıyla Tamamlandı";
                    return RedirectToAction(nameof(Get));
                }
                else
                {
                    TempData["Error"] = "Bir Hata Meydana Geldi!";
                    return View(modelVM);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }
        [HttpGet]
        public virtual IActionResult AddByUsername()
        {
            return View();
        }
        [HttpPost]
        public virtual async Task<IActionResult> AddByUsername(string userName, TWriteViewModel modelVM)
        {
            if (ModelState.IsValid)
            {
                T entity = _mapper.Map<T>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _writeRepository.AddAsync(entity);
                if (result)
                {
                    await _writeRepository.SaveChangesAsync();
                    TempData["Success"] = "Ekleme İşlemi Başarıyla Tamamlandı";
                    return RedirectToAction(nameof(Get));
                }
                else
                {
                    TempData["Error"] = "Bir Hata Meydana Geldi!";
                    return View(modelVM);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> AddWithFile(string userName, TWriteViewModel modelVM, IFormFile file)
        {
            if (ModelState.IsValid)
            {
                T entity = _mapper.Map<T>(modelVM);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, nameof(Add));
                var result = await _writeRepository.AddAsync(entity);
                if (result)
                {
                    await _writeRepository.SaveChangesAsync();
                    TempData["Success"] = "Ekleme İşlemi Başarıyla Tamamlandı";
                    return RedirectToAction(nameof(Add));
                }
                else
                {
                    TempData["Error"] = "Bir Hata Meydana Geldi!";
                    return RedirectToAction(nameof(Add), modelVM);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return RedirectToAction(nameof(Add), modelVM);
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> Update(Guid id)
        {
            var entity = await _readRepository.GetAllActivesByIdAsync(id);
            if (entity != null)
            {
                TWriteViewModel modelVM = _mapper.Map<TWriteViewModel>(entity);
                return View(modelVM);
            }
            else
            {
                TempData["Error"] = "Bu Veri Silinmiş!";
                return View(nameof(Get));
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Update(TWriteViewModel modelVM)
        {
            if (ModelState.IsValid)
            {
                T entity = await _readRepository.GetAllActivesByIdAsync(modelVM.Id);
                if (entity != null)
                {
                    var resultUpdate = _writeRepository.Update(entity, modelVM);
                    if (resultUpdate)
                    {
                        await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, $"{nameof(Update)}Post");
                        await _writeRepository.SaveChangesAsync();
                        TempData["Success"] = "Güncelleme İşlemi Başarıyla Tamamlandı";
                        return RedirectToAction(nameof(Get));
                    }
                    else
                    {
                        TempData["Error"] = "Bir Hata Meydana Geldi!";
                        return View(modelVM);
                    }
                }
                else
                {
                    TempData["Error"] = "Bu Veri Silinmiş!";
                    return View(nameof(Get));
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }

        [HttpGet]
        public virtual async Task<IActionResult> UpdateByUsername(Guid id)
        {
            var entity = await _readRepository.GetAllActivesByIdAsync(id);
            if (entity != null)
            {
                TWriteViewModel modelVM = _mapper.Map<TWriteViewModel>(entity);
                return View(modelVM);
            }
            else
            {
                TempData["Error"] = "Bu Veri Silinmiş!";
                return View(nameof(Get));
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> UpdateByUsername(string userName, TWriteViewModel modelVM)
        {
            if (ModelState.IsValid)
            {
                T entity = await _readRepository.GetAllActivesByIdAsync(modelVM.Id);
                if (entity != null)
                {
                    var resultUpdate = _writeRepository.Update(entity, modelVM);
                    if (resultUpdate)
                    {
                        await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, $"{nameof(Update)}Post");
                        await _writeRepository.SaveChangesAsync();
                        TempData["Success"] = "Güncelleme İşlemi Başarıyla Tamamlandı";
                        return RedirectToAction(nameof(Get));
                    }
                    else
                    {
                        TempData["Error"] = "Bir Hata Meydana Geldi!";
                        return View(modelVM);
                    }
                }
                else
                {
                    TempData["Error"] = "Bu Veri Silinmiş!";
                    return View(nameof(Get));
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(modelVM);
            }
        }


        [HttpGet]
        public virtual async Task<IActionResult> Delete(Guid id)
        {
            await _writeRepository.RemoveByIdAsync(id);
            await _writeRepository.SaveChangesAsync();
            TempData["Success"] = "Silme İşlemi Başarıyla Tamamlandı";
            return RedirectToAction(nameof(Get));
        }


    }
}
