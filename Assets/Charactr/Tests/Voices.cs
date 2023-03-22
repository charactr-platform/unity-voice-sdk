using System.Threading.Tasks;
using Charactr.VoiceSDK.Model;
using Charactr.VoiceSDK.SDK;
using NUnit.Framework;

namespace Charactr.VoiceSDK.Tests
{
    public class Voices: TestBase
    {
        private const string ENDPOINT = "voices";
        
        [Test]
        public async Task GetVoices_Returns_OK()
        {
            var voices = await Http.GetAsync<VoicesResponse>(Configuration.API + ENDPOINT);
            Assert.NotNull(voices);
            Assert.IsNotEmpty(voices);
        }
    }
}