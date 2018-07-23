using Project.UserControls;
using System.Linq;

namespace CleanCode._12_FullRefactoring
{
    public class PostDAO
    {
        private readonly PostDbContext _dBContext;

        public PostDAO()
        {
            _dBContext = new PostDbContext();
        }

        public void AddPost(Post post)
        {
            _dBContext.Posts.Add(post);
            _dBContext.SaveChanges();
        }

        public Post GetPostById(int postId)
        {
            return _dBContext.Posts.SingleOrDefault(p => p.Id == postId);
        }
    }
}
