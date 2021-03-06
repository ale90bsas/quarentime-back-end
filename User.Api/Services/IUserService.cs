using System.Threading.Tasks;
using User.Api.Model;

namespace User.Api.Services
{
    public interface IUserService
    {
        Task UpdatePersonalInformationAsync(string userId, PersonalInformation value);
        Task UpdateSurveyInfo(string userId, SurveyIntake value);
        Task<PersonalInformation> GetPersonalInformationAsync(string userId);
        Task<SurveyIntake> GetSurveyInfoAsync(string userId);
    }
}
