using Maths2D.Data;

namespace Maths2D.Repository
{
    public class PostsRepository : IPostRepository
    {
        private readonly PostDbContext _context;

        public PostsRepository(PostDbContext songDbContext)
        {
            this._context = songDbContext;
        }

        public List<Post> GetAllPosts()
        {
            return _context.Posts.Select(x => x).ToList();
        }

        public bool AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();

            return true;
        }

        public bool DeletePost(int id)
        {
            _context.Posts.Remove(GetPostById(id));
            _context.SaveChanges();
            return true;
        }

        public Post GetPostById(int id)
        {
            var findSong = _context.Posts.Find(id);
            return findSong;
        }

        public bool UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();

            return true;
        }
    }
}
