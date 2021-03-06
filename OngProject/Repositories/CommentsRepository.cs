using Microsoft.EntityFrameworkCore;
using OngProject.Core.Interfaces;
using OngProject.Core.Mapper;
using OngProject.DataAccess;
using OngProject.Entities;
using OngProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OngProject.Repositories
{
    public class CommentsRepository: Repository<Comentaries>, ICommentsRepository
    {
        private readonly EntityMapper mapper = new EntityMapper();
        public CommentsRepository(ApplicationDbContext context, IUriService uriservice) : base(context, uriservice) { }

        public async Task<List<ComentariesFromNewsDTO>> GetComementsFromNew(int newId)
        {
            var comentaries = await _dbSet.Where(x => x.NewsId == newId && x.IsDeleted == false).ToListAsync();

            if (comentaries.Count > 0)
            {
                return mapper.ToComentariesListDTO(comentaries);
            }
            else
            {
                return null;
            }   
        }
    }
}
