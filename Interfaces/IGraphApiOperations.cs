using System.Threading.Tasks;

namespace WebApp_OpenIDConnect_DotNet.Interfaces
{
    public interface IGraphApiOperations
    {
        Task<dynamic> CallOnBehalfOfUserAsync(string accessToken);
    }
}