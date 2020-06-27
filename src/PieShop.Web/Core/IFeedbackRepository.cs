using PieShop.Web.Models;

namespace PieShop.Web.Core
{
    public interface IFeedbackRepository
    {
        void AddFeedback(Feedback feedback);
    }
}
