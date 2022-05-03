using System;
using System.Collections.Generic;
using System.Text;
using Adni.Domain.Entities;

namespace Adni.Domain.Interfaces.CompanyListInterface
{
    public interface ICompanyListInterfaces 
    {
        public void SetCompanyList(IList<Company> list);
        public IList<Company> GetCompanyList();
    }

    public interface ICompanyListIdInterfaces
    {
        public void SetCompanyListId(Guid companyListId);
    }
    public interface ICompanyList
    {
        string SetCompanyListCity(CompaniesList companiesList);
    }
    public interface ICompanyListCityGet
    {
        void GetCompanyListCity(Guid companyListId);
    }
}
