using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TextGame.Engine.Entities;
using TextGame.Engine.Models;
using TextGame.Engine.Services;

namespace TextGame.WebUI.Controllers
{
    public class MapController : Controller
    {
        private readonly SceneService _sceneService;
        public MapController(SceneService sceneService)
        {
            _sceneService = sceneService;
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromForm]SceneDTO sceneDTO)
        {
            var scene = sceneDTO.Adapt<Scene>();

            await _sceneService.Create(scene);
            return Redirect("/Map");
        }

        public async Task<IActionResult> Edit([FromForm]SceneDTO sceneDTO)
        {
            var scene = sceneDTO.Adapt<Scene>();

            await _sceneService.Edit(scene);
            return Redirect("/Map/GetAllScenes");
        }

        [HttpGet]
        public async Task<IActionResult> GetScenes()
        {
            var scenes = await _sceneService.GetScenes().ToListAsync();

            return new JsonResult(scenes);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllScenes()
        {
            var scenes = await _sceneService.GetScenes().ToListAsync();
            return View(scenes);
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var scene = await _sceneService.Get(id);
            if (scene == null)
            {
                return NotFound();
            }
            return new JsonResult(scene);
        }



    }
}
