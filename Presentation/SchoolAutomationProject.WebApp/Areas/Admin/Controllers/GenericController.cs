using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipHelpers;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenericController<T, TReadViewModel, TWriteViewModel> : Controller where T : BaseClass where TReadViewModel : class where TWriteViewModel : class
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
            var entities = _readRepository.GetAll().ToList();
            List<TReadViewModel> readViewModelList = _mapper.Map<List<TReadViewModel>>(entities);
            return View(readViewModelList);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Details(string id)
        {
            var entity = await _readRepository.GetByIdAsync(id);
            TReadViewModel readViewModel = _mapper.Map<TReadViewModel>(entity);
            return View(readViewModel);
        }

        [HttpGet]
        public virtual IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public virtual async Task<IActionResult> Add(TWriteViewModel model)
        {
            //todo T tipinde nesne oluşturulacak.
            if (ModelState.IsValid)
            {
                T entity = _mapper.Map<T>(model); // Model'i varlık türüne eşle
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, model);
                var result = await _writeRepository.AddAsync(entity);
                if (result)
                {
                    await _writeRepository.SaveChangesAsync();
                    TempData["Success"] = "Ekleme işlemi başarıyla gerçekleşti";
                    return RedirectToAction(nameof(Get));
                }
                else
                {
                    TempData["Error"] = "Bir hata meydana geldi!";
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(model);
            }
        }


        [HttpGet]
        public virtual async Task<IActionResult> Update(Guid id, TWriteViewModel model)
        {
            var entity = await _readRepository.GetByIdAsync(id.ToString());
            if (entity != null)
            {
                model = _mapper.Map<TWriteViewModel>(entity);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, model);
                var resultUpdate = _writeRepository.Update(entity);
                if (resultUpdate)
                {
                    await _writeRepository.SaveChangesAsync();
                    TempData["Success"] = "Güncelleme işlemi başarıyla gerçekleşti";
                    return RedirectToAction(nameof(Get));
                }
                else
                {
                    TempData["Error"] = "Bir hata meydana geldi!";
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(model);
            }
        }

        [HttpPost]
        public virtual async Task<IActionResult> Update(string id, TWriteViewModel model)
        {
            if (ModelState.IsValid)
            {
                T entity = await _readRepository.GetByIdAsync(id);
                if (entity != null)
                {
                    entity = _mapper.Map<T>(model);
                    await _fillEntityRelationshipsService.FillEntityRelationships(entity, model);
                    var resultUpdate = _writeRepository.Update(entity);
                    if (resultUpdate)
                    {
                        await _writeRepository.SaveChangesAsync();
                        TempData["Success"] = "İşlem başarılıyla tamamlandı";
                        return RedirectToAction(nameof(Get));
                    }
                    else
                    {
                        TempData["Error"] = "Bir hata meydana geldi!";
                        return View(model);
                    }
                }
                else
                {
                    TempData["Error"] = "Bir hata meydana geldi!";
                    return View(model);
                }
            }
            else
            {
                TempData["Error"] = "Bir hata meydana geldi!";
                return View(model);
            }
        }


        [HttpGet]
        public virtual async Task<IActionResult> Delete(string id)
        {
            await _writeRepository.RemoveByIdAsync(id);
            await _writeRepository.SaveChangesAsync();
            return RedirectToAction(nameof(Get));
        }


    }
}
