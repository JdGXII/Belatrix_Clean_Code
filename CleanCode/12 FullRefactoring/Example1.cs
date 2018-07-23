using CleanCode._12_FullRefactoring;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web.UI.WebControls;


namespace Project.UserControls
{
    public class PostControl : System.Web.UI.UserControl
    {
        private readonly PostDAO _postDao;
        public Label PostBody { get; set; }
        public Label PostTitle { get; set; }
        public int? PostId { get; set; }


        public PostControl()
        {
            _postDao = new PostDAO();
        }

        private Post GetPost()
        {
            return new Post
            {
                Id = Convert.ToInt32(PostId.Value),
                Title = PostTitle.Text.Trim(),
                Body = PostBody.Text.Trim()
            };
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
                SavePost();
            else
                RegularPageLoad();
        }

        private void RegularPageLoad()
        {
            Post entity = _postDao.GetPostById(Convert.ToInt32(Request.QueryString["id"]);
            PostBody.Text = entity.Body;
            PostTitle.Text = entity.Title;
        }

        private void SavePost()
        {
            Post post = GetPost();
            ValidationResult validation = PostValidation(post);
            if (validation.IsValid)
                _postDao.AddPost(post);

            HandleErrors(validation.Errors);
        }

        private void HandleErrors(IEnumerable<ValidationError> errors)
        {
            BulletedList summary = (BulletedList)FindControl("ErrorSummary");            
            foreach (var failure in errors)
            {
                Label errorMessage = FindControl(failure.PropertyName + "Error") as Label;

                if (errorMessage == null)
                {
                    summary.Items.Add(new ListItem(failure.ErrorMessage));
                }
                else
                {
                    errorMessage.Text = failure.ErrorMessage;
                }
            }
        }

        private ValidationResult PostValidation(Post entity)
        {
            PostValidator validator = new PostValidator();
            return validator.Validate(entity);
        }



    }

    #region helpers

    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public IEnumerable<ValidationError> Errors { get; set; }
    }

    public class ValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class PostValidator
    {
        public ValidationResult Validate(Post entity)
        {
            throw new NotImplementedException();
        }
    }

    public class DbSet<T> : IQueryable<T>
    {
        public void Add(T entity)
        {
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public Expression Expression
        {
            get { throw new NotImplementedException(); }
        }

        public Type ElementType
        {
            get { throw new NotImplementedException(); }
        }

        public IQueryProvider Provider
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class PostDbContext
    {
        public DbSet<Post> Posts { get; set; }

        public void SaveChanges()
        {
        }
    }
    #endregion

}