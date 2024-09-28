using Nutrition.Web.DTOs;

namespace Nutrition.Web;

public class AuthApiClient
{
    private readonly HttpClient _httpClient;

    public AuthApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> Register(UserRegistrationDTO dto, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsJsonAsync("/register", dto, cancellationToken);
        return response.IsSuccessStatusCode;
    }

    public async Task<bool> Login(UserLoginDTO dto, CancellationToken cancellationToken = default)
    {
        var response = await _httpClient.PostAsJsonAsync("/login", dto, cancellationToken);
        return response.IsSuccessStatusCode;
    }
}
