using System.Buffers.Text;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample2
{
    public class ImagePost : Post
    {
        protected string ImageURL { get; set; }

        public ImagePost()
        {
            this.ImageURL = "This is nothing from the nothing place.com";
        }
        
        //both this is the constructor underneath are relatively the same exact thing.
        public ImagePost(int id, string title, string userSentBy, bool isPublic, string _IMAGEURL) : base(id, title, userSentBy, isPublic)
        {
            this.ImageURL = _IMAGEURL;
        }

        public ImagePost(string _imageUrl, string _title, string _sentByUser, bool _isPublic)
        {
            this.ImageURL = _imageUrl;
            this.id = GetNextId();
            this.title = _title;
            this.sentByUserName = _sentByUser;
            this.isPublic = _isPublic;
            
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + " \nThe image url for the website i am visiting is: {0}", this.ImageURL);
        }
    }
}