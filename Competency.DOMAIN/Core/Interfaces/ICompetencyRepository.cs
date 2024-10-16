
using Competency.DOMAIN.Core.Entities;
namespace Competency.DOMAIN.Core.Interfaces
{
    public interface ICompetencyRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Competency.DOMAIN.Core.Entities.Competency>> GetCompetencies();
        Task Insert(Competency.DOMAIN.Core.Entities.Competency competency);
        Task<bool> Update(Competency.DOMAIN.Core.Entities.Competency competency);
    }
}