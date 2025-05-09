﻿using HomestayManagementAPI.Model;
using HomestayManagementAPI.Repositories.Interfaces;
using HomestayManagementAPI.Services.Interfaces;

namespace HomestayManagementAPI.Services
{
    public class CategoryArticleService : ICategoryArticleService
    {
        private readonly ICategoryArticleRepository _repository;

        public CategoryArticleService(ICategoryArticleRepository repository)
        {
            _repository = repository;
        }

        public Task<IEnumerable<CategoryArticle>> GetAllCategoryArticles()
        {
            return _repository.GetAllCategoryArticles();
        }

        public Task<CategoryArticle?> GetCategoryArticleById(int id)
        {
            return _repository.GetCategoryArticleById(id);
        }

        public Task<bool> AddCategoryArticle(CategoryArticle categoryArticle)
        {
            return _repository.AddCategoryArticle(categoryArticle);
        }

        public Task<bool> UpdateCategoryArticle(CategoryArticle categoryArticle)
        {
            return _repository.UpdateCategoryArticle(categoryArticle);
        }

        public Task<bool> DeleteCategoryArticle(int id)
        {
            return _repository.DeleteCategoryArticle(id);
        }      

        public bool CategoryArticleExists(int id)
        {
            return _repository.CategoryArticleExists(id);
        }
    }
}
