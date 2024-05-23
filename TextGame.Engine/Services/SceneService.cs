using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TextGame.Engine.Data;
using TextGame.Engine.Entities;

namespace TextGame.Engine.Services
{
    public class SceneService
    {
        private readonly DataContext _dataContext;

        public SceneService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }   

        public async Task Create(Scene scene) 
        { 
            await _dataContext.AddAsync(scene);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Edit(Scene scene)
        {
            _dataContext.Update(scene);
            await _dataContext.SaveChangesAsync();
        }

        public IQueryable<Scene> GetScenes()
        {
            return _dataContext.Set<Scene>();
        }

        public async Task<Scene> Get(int id)
        {
            return await _dataContext.Scenes.FirstOrDefaultAsync(scene => scene.ID == id);
        }
    }
}
