using Entities.Models;

namespace Contracts
{
    public interface ICompanyRepository
    {
        IEnumerable<Company> GetAllCompanies(bool trackChange);
        Company GetCompany(Guid companyId, bool trackChange);
    }
}
