using System.Collections.Generic;
using AutoMapper;
using LearningSystem.Models.EntityModels;
using LearningSystem.Models.ViewModels.Blog;

namespace LearningSystem.Services
{
    public class BlogService: Service
    {
        public IEnumerable<ArticleViewModel> GetAllArticles()
        {
            IEnumerable<Article> articles = this.Context.Articles;
            IEnumerable<ArticleViewModel> avms = Mapper.Map<IEnumerable<Article>, IEnumerable<ArticleViewModel>>(articles);

            return avms;
        }
    }
}
