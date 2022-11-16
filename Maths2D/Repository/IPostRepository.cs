using Maths2D.Data;

namespace Maths2D.Repository
{
    public interface IPostRepository
    {
        List<Post> GetAllPosts();
        Post GetPostById(int id);
        bool AddPost(Post book);
        bool UpdatePost(Post book);
        bool DeletePost(int id);
    }
}
