using System.Text;

namespace Katas
{
    public class kyu5MySmallestCodeInterpreterAkaBrainf__k
    {
        public static string BrainLuck(string code, string input)
        {
            var dataPointer = 0;
            var codePointer = -1;
            var memory = new byte[9999];
            var output = new StringBuilder();
            while (++codePointer < code.Length)
            {
                if (code[codePointer] == ',') input = ReadData(input, memory, dataPointer);
                if (code[codePointer] == '.') Print(output, memory[dataPointer]);
                if (code[codePointer] == '+') memory[dataPointer]++;
                if (code[codePointer] == '-') memory[dataPointer]--;
                if (code[codePointer] == '>') dataPointer++;
                if (code[codePointer] == '<') dataPointer--;
                if (code[codePointer] == '[' && memory[dataPointer] == 0) codePointer = ForwardToNextCommand(code, codePointer);
                if (code[codePointer] == ']' && memory[dataPointer] != 0) codePointer = BackToNextCommand(code, codePointer);
            }
            return output.ToString();
        }

        private static string ReadData(string input, byte[] inputData, int dataPointer)
        {
            inputData[dataPointer] = (byte) input[0];
            input = input.Substring(1);
            return input;
        }

        private static byte Print(StringBuilder output, byte inputData)
        {
            output.Append((char) inputData);
            inputData = 0;
            return inputData;
        }

        private static int BackToNextCommand(string code, int codePointer)
        {
            var numberOfBrackets = 0;
            for (var i = codePointer - 1; i >= 0; i--)
            {
                if (code[i] == '[' && numberOfBrackets == 0) {
                    codePointer = i;
                    break;
                }
                if (code[i] == '[' && numberOfBrackets > 0) numberOfBrackets--;
                if (code[i] == ']') numberOfBrackets++;
            }
            return codePointer;
        }
        private static int ForwardToNextCommand(string code, int codePointer)
        {
            var numberOfBrackets = 0;
            for (var i = codePointer + 1; i < code.Length; i++)
            {
                if (code[i] == ']' && numberOfBrackets == 0)
                {
                    codePointer = i;
                    break;
                }
                if (code[i] == ']' && numberOfBrackets > 0) numberOfBrackets--;
                if (code[i] == '[') numberOfBrackets++;
            }
            return codePointer;
        }
    }
}