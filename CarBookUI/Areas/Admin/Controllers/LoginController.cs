using DTO.LoginDtos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;
using CarBookUI.Models;
using System.Drawing.Drawing2D;

namespace CarBookUI.Areas.Admin.Controllers
{

	[Area("Admin")]
	[Route("Admin/[Controller]/[Action]")]
	public class LoginController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public LoginController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}


		[HttpPost]
		public async Task<IActionResult> Index(LoginDto login)
		{
			var client = _httpClientFactory.CreateClient();
			var json = JsonConvert.SerializeObject(login);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await client.PostAsync("https://localhost:7217/api/AppUser", content);

			var jsons = await response.Content.ReadAsStringAsync();
			var value = JsonConvert.DeserializeObject<GetAppCheckUserQueryResult>(jsons);


			if (value.Role == "başarısız")
			{


				return View();


			}

			var jsonData = await response.Content.ReadAsStringAsync();
			var tokenModel = System.Text.Json.JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
			{
				PropertyNamingPolicy = JsonNamingPolicy.CamelCase
			});

			if (tokenModel != null)
			{
				JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
				var token = handler.ReadJwtToken(tokenModel.Token);
				var claims = token.Claims.ToList();

				if (tokenModel.Token != null)
				{
					claims.Add(new Claim("carbooktoken", tokenModel.Token));
					var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
					var authProps = new AuthenticationProperties
					{
						ExpiresUtc = tokenModel.ExpireDate,
						IsPersistent = true
					};

					await HttpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);
					return RedirectToAction("Index", "About");
				}
			}

			return View();

		}




	}
}

