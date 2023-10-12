using Microsoft.AspNetCore.Mvc;
using MVCClient.Models;
using OpenAI.Managers;
using OpenAI.ObjectModels.RequestModels;
using OpenAI.ObjectModels;
using System.Diagnostics;
using OpenAI.Interfaces;

namespace MVCClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IOpenAIService _openAIService;

        public HomeController(ILogger<HomeController> logger, IOpenAIService openAIService)
        {
            _logger = logger;
            _openAIService = openAIService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var viewModel= new HomeIndexVievModel();
            return View(viewModel);
        }
        [HttpPost]  
        public async Task<IActionResult> Index(HomeIndexVievModel vievModel)
        {
            //var imageResult = await _openAIService.Image.CreateImage(new ImageCreateRequest
            //{
            //    Prompt = vievModel.Prompt,
            //    N = vievModel.ImageCount,
            //    Size = StaticValues.ImageStatics.Size.Size512,
            //    ResponseFormat = StaticValues.ImageStatics.ResponseFormat.Url,
            //    User = "KalayMaster"
            //});



            //if (imageResult.Successful)
            //{
            //    vievModel.ImageUrls = imageResult.Results.Select(r => r.Url).ToList();
            //}
            var completionResult = await _openAIService.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = new List<ChatMessage>
                {
                    ChatMessage.FromUser(vievModel.Prompt)
                },
                Model = OpenAI.ObjectModels.Models.Gpt_3_5_Turbo,
                MaxTokens = 4000//optional
            });
            if (completionResult.Successful)
            {
                vievModel.ChatGPTResponse=  completionResult.Choices.First().Message.Content;
            }

            return View(vievModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}