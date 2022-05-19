using System;

namespace UDEMYMASTERCLASSFORCSHARP.InheritanceExample2
{
    public class Post
    {
        private static int currentPostId;

        //Properties - 
        protected int id { get; set; }
        protected string title { get; set; }
        protected string sentByUserName { get; set; }
        protected bool isPublic { get; set; }

        public Post()
        {
            id = GetNextId();
            title = "this is a title";
            sentByUserName = "BaseUser";
            isPublic = true;
        }

        public Post(int _id, string _title, string _sentByUserName, bool _isPublic)
        {
            this.id = _id;
            this.title = _title;
            this.sentByUserName = _sentByUserName;
            this.isPublic = _isPublic;
        }


        public Post(string _title, string _sentByUserName, bool _isPublic)
        {
            this.id = GetNextId();
            this.title = _title;
            this.sentByUserName = _sentByUserName;
            this.isPublic = _isPublic;
        }

        protected int GetNextId()
        {
            return currentPostId++;
        }

        public void Update(string title, bool isPublic)
        {
            this.title = title;
            this.isPublic = isPublic;
        }
        
        public override string ToString()
        {
            return string.Format(
                "The id of the post is {0}, The title of the post is {1} and the user who sent it is {2}", this.id,
                this.title, this.sentByUserName);
        }
    }
}