using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    public sealed class Post
    {
        private Post()
        {

        }
        private static readonly Lazy<Post> lazyInstance = new Lazy<Post>(() => new Post());

        public static Post Instance
        {
            get {
                return lazyInstance.Value;
            }
        }

        public void SendMessage(User user, Message message)
        {
            user.GetMessage(message);
        }
    }
}
