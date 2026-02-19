using System.Linq;
using Game339.Shared.Diagnostics;

namespace Game339.Shared.Services.Implementation
{
    public class StringService : IStringService
    {
        private readonly IGameLog _log;

        public StringService(IGameLog log)
        {
            _log = log;
        }

        public string Reverse(string input)
        {
            var output = new string(input.Reverse().ToArray());
            _log.Info($"{nameof(StringService)}.{nameof(Reverse)} - {nameof(input)}: {input} - {nameof(output)}: {output}");
            return output;
        }
        
        // test for recommit
        
        public string ReverseWords(string input)
        {
            var words = input.Split(' ');
            System.Array.Reverse(words);
            var output = string.Join(' ', words);
            _log.Info($"{nameof(StringService)}.{nameof(ReverseWords)} - {nameof(input)}: {input} - {nameof(output)}: {output}");
            return output;
        }
    }
}