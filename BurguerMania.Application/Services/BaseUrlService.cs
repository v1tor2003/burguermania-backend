using BurguerMania.Domain.Interfaces;
using Microsoft.AspNetCore.Http;

namespace BurguerMania.Application.Services
{
    public class BaseUrlService : IBaseUrlService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseUrlService(IHttpContextAccessor httpContextAccessor) =>
            _httpContextAccessor = httpContextAccessor;
        
        public string GetBaseUrl()
        {
            var request = _httpContextAccessor.HttpContext?.Request;
            return request != null ? $"{request.Scheme}://{request.Host}" : string.Empty;
        }
    }
}