using System;
using System.Collections.Generic;
using System.Text;

namespace Katas
{
    public class BefungeInterpreter
    {
        public static void Main(string[] args)
        {
            
        }

        char[][] codeBoard;
        int[] codePointer = {0, 0};
        private const int X = 1;
        private const int Y = 0;
        Stack<int> stack = new Stack<int>();
        char comand;
        enum Direction { LEFLT, RIGHT, UP, DOWN }
        Direction DIRECTION = Direction.RIGHT;
        StringBuilder output = new StringBuilder();
        bool stringMode;

        public string Interpret(string code)
        {
            MakeBoard(code);
            while (true)
            {
                comand = codeBoard[codePointer[0]][codePointer[1]];

                switch (comand)
                {
                    case var tempNumber when (comand >= '0' && comand <= '9'):
                        stack.Push(int.Parse(tempNumber.ToString()));
                        break;
                    case '+':
                        stack.Push(stack.Pop() + stack.Pop());
                        break;
                    case '-':
                        var tempNumberMinus = stack.Pop();
                        stack.Push(stack.Pop() - tempNumberMinus);
                        break;
                    case '*':
                        stack.Push(stack.Pop() * stack.Pop());
                        break;
                    case '/':
                        Divided();
                        break;
                    case '%':
                        Modulo();
                        break;
                    case '!':
                        if(!stringMode) stack.Push((stack.Pop() == 0) ? 1 : 0);
                        break;
                    case '`':
                        var tempBackTick = stack.Pop();
                        stack.Push((stack.Pop() > tempBackTick) ? 1 : 0);
                        break;
                    case '>':
                        DIRECTION = Direction.RIGHT;
                        break;
                    case '<':
                        DIRECTION = Direction.LEFLT;
                        break;
                    case '^':
                        DIRECTION = Direction.UP;
                        break;
                    case 'v':
                        DIRECTION = Direction.DOWN;
                        break;
                    case '?':
                        var tempDirectionsForRand = new[] {Direction.RIGHT, Direction.LEFLT, Direction.UP, Direction.DOWN};
                        DIRECTION = tempDirectionsForRand[new Random().Next(tempDirectionsForRand.Length)];
                        break;
                    case '_':
                        DIRECTION = (stack.Pop() == 0)? Direction.RIGHT: Direction.LEFLT;
                        break;
                    case '|':
                        DIRECTION = (stack.Pop() == 0)? Direction.DOWN: Direction.UP;
                        break;
                    case '\"':
                        stringMode = !stringMode;
                        Move();
                        continue;
                    case ':':
                        Duplicate();
                        break;
                    case '\\':
                        Swap();
                        break;
                    case '$':
                        stack.Pop();
                        break;
                    case '.':
                        output.Append(stack.Pop());
                        break;
                    case ',':
                        output.Append((char)stack.Pop());
                        break;
                    case '#':
                        Move();
                        break;
                    case 'p':
                        var tempY = stack.Pop();
                        var tempX = stack.Pop();
                        var tempV = stack.Pop();
                        codeBoard[tempY][tempX] = (char) tempV;
                        break;
                    case 'g':
                        tempY = stack.Pop();
                        tempX = stack.Pop();
                        stack.Push(codeBoard[tempY][tempX]);
                        break;
                }

                if (stringMode) stack.Push(comand);
                if (comand == '@') break;
                Move();
            }
            return (output.Length == 0 )?code:output.ToString();
        }


        private void Move()
        {
            if (DIRECTION == Direction.RIGHT)
            {
                codePointer[X]++;
                if (codePointer[X] > codeBoard[Y].Length) codePointer[X] = 0;
            }
            else if (DIRECTION == Direction.LEFLT)
            {
                codePointer[X]--;
                if (codePointer[X] < 0) codePointer[X] = codeBoard[Y].Length - 1;
            }
            else if (DIRECTION == Direction.DOWN)
            {
                codePointer[Y]++;
                if (codePointer[Y] > codeBoard.Length) codePointer[Y] = 0;
            }
            else if (DIRECTION == Direction.UP)
            {
                codePointer[Y]--;
                if (codePointer[Y] < 0) codePointer[Y] = codeBoard.Length - 1;
            }
        }

        private void Swap()
        {
            if (stack.Count > 1)
            {
                var tempSwapA = stack.Pop();
                var tempSwapB = stack.Pop();
                stack.Push(tempSwapA);
                stack.Push(tempSwapB);
            }
            else
            {
                var tempSwapA = stack.Pop();
                var tempSwapB = 0;
                stack.Push(tempSwapA);
                stack.Push(tempSwapB);
            }
        }

        private void Duplicate()
        {
            if (stack.Count != 0)
            {
                var tempDuplicate = stack.Pop();
                stack.Push(tempDuplicate);
                stack.Push(tempDuplicate);
            }
            else
            {
                stack.Push(0);
            }
        }

        private void Divided()
        {
            var tempNumberDivided = stack.Pop();
            if (tempNumberDivided == 0)
            {
                stack.Pop();
                stack.Push(0);
            }

            stack.Push(stack.Pop() / tempNumberDivided);
        }

        private void Modulo()
        {
            var tempNumberDivided = stack.Pop();
            if (tempNumberDivided == 0)
            {
                stack.Pop();
                stack.Push(0);
            }

            stack.Push(stack.Pop() % tempNumberDivided);
        }

        private void MakeBoard(string code)
        {
            var codeSplit = code.Split("\n");
            codeBoard = new char[codeSplit.Length][];
            for (var i = 0; i < codeSplit.Length; i++)
            {
                codeBoard[i] = codeSplit[i].ToCharArray();
            }
        }
    }
}