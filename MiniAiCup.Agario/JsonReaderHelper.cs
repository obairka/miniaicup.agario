using System.IO;
using System.Text;

namespace MiniAiCup.Agario
{
    public static class JsonReaderHelper
    {
        public static string ReadJson(Stream input, out bool result)
        {
            var reader = new StreamReader(input);
            var braketsCount = 0;
            var stringBuilder = new StringBuilder();
            
            while (!reader.EndOfStream)
            {
                var character = reader.Read();
                stringBuilder.Append((char)character);

                switch (character)
                {
                    case '{':
                        braketsCount++;
                        break;
                    case '}':
                        braketsCount--;
                        if (braketsCount == 0)
                        {
                            result = true;
                            return stringBuilder.ToString();
                        }

                        break;
                }
            }
            result = false;
            return stringBuilder.ToString();
        }
    }
}