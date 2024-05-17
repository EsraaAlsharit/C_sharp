#pragma warning disable CS8618

namespace TheWall.Models;
public class Post
{
    public Message Message { get; set; }
    public List<Message> AllMessages { get; set; }
    public Comment Comment { get; set; }
    public List<Comment> AllComments { get; set; }

}
