namespace HomestayManagementAPI.Services.Interfaces
{
    public interface ICategoryArticleService
    {
        Task<IEnumerable<CategoryArticle>> GetAllCategoryArticles();
        Task<CategoryArticle?> GetCategoryArticleById(int id);
        Task<bool> AddCategoryArticle(CategoryArticle categoryArticle);
        Task<bool> UpdateCategoryArticle(CategoryArticle categoryArticle);
        Task<bool> DeleteCategoryArticle(int id);
        bool CategoryArticleExists(int id);
    }
}
