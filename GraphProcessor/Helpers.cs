using System;
using System.Text.Json;

namespace GraphProcessor
{
    public class Helpers
    {
        public static bool CheckValidAnswer(string[] ValidAnswers, string givenAnswer)
        {
            foreach (var answer in ValidAnswers)
            {
                if (givenAnswer == answer)
                {
                    return true;
                }
            }

            return false;
        }

        public static T DeserializeJSON<T>(string rawJSON)
        {
            {
                var options = new JsonSerializerOptions
                {
                    AllowTrailingCommas = true
                };

                return JsonSerializer.Deserialize<T>(rawJSON, options);
            }
        }
    }
}
