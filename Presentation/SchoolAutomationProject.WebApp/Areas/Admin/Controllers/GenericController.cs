using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SchoolAutomationProject.Application.Helpers.EntityRelationshipsHelpers.CommonEntityFillRelationshipsServices;
using SchoolAutomationProject.Application.Repositories.CommonRepositories;
using SchoolAutomationProject.Application.ViewModels.BaseViewModels;
using SchoolAutomationProject.Domain.Entities.CommonTables;

namespace SchoolAutomationProject.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenericController<T, TReadViewModel, TWriteViewModel> : Controller where T : BaseClass where TReadViewModel : ReadViewModel where TWriteViewModel : WriteViewModel
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
        public virtual async Task<IActionResult> Add(TWriteViewModel modelVM)
        {
            //todo T tipinde nesne oluşturulacak.
            if (ModelState.IsValid)
            {
                T entity = _mapper.Map<T>(modelVM); // Model'i varlık türüne eşle
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
        public virtual async Task<IActionResult> Update(string id)
        {
            var entity = await _readRepository.GetByIdAsync(id);
            if (entity != null)
            {
                TWriteViewModel modelVM = _mapper.Map<TWriteViewModel>(entity);
                await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, $"{nameof(Update)}Get");
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
                T entity = await _readRepository.GetByIdAsync(modelVM.Id.ToString());
                if (entity != null)
                {
                    await _fillEntityRelationshipsService.FillEntityRelationships(entity, modelVM, $"{nameof(Update)}Post");
                    var resultUpdate = _writeRepository.Update(entity);
                    if (resultUpdate)
                    {
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
        public virtual async Task<IActionResult> Delete(string id)
        {
            var resultDelete = await _writeRepository.RemoveByIdAsync(id);
            if (!resultDelete)
            {
                TempData["Error"] = "Silme İşleminde Bir Hata Meydana Geldi";
                return View(nameof(Get));
            }
            await _writeRepository.SaveChangesAsync();
            TempData["Success"] = "Silme İşlemi Başarıyla Tamamlandı";
            return RedirectToAction(nameof(Get));
        }


    }
}
