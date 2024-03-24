using WebApi.Application.Bases;

namespace WebApi.Application.Features.Products.Exceptions
{
    public class ProductTitleMustNotBeSameException : BaseExceptions
    {
        public ProductTitleMustNotBeSameException() : base("Aynı ürün başlığı zaten mevcut!") { }
    }
}
