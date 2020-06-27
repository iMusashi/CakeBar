using PieShop.Web.Core;
using PieShop.Web.Data;
using PieShop.Web.Models;

namespace PieShop.Web.Impl
{
    public class FeedbackRepository: IFeedbackRepository
    {
        private readonly AppDbContext _appDbContext;

        public FeedbackRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void AddFeedback(Feedback feedback)
        {
            _appDbContext.Feedbacks.Add(feedback);
            _appDbContext.SaveChanges();
        }
    }
}
