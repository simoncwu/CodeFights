using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    public class SnakeCube
    {
        public char[][] snakeCube(char[][] board, string commands)
        {
            char d;
            var snake = FindSnake(board, out d);
            var u = snake.First.Value;
            foreach (var c in commands)
            {
                Execute(board, c, snake, ref d);
                if (d == 'x')
                    break;
            }
            return board;
        }

        LinkedList<int[]> FindSnake(char[][] board, out char d)
        {
            var snake = new LinkedList<int[]>();
            d = ' ';

            int r = -1, c = r, n = board.Length / 3;
            while (c < 0)
            {
                c = Array.FindIndex(board[++r], _ => "^>v<".Contains(_));
            }
            snake.AddLast(new[] { r, c });

            int lastR = r, lastC = c;
            Seek:
            foreach (var h in "<>^v")
            {
                var D = h;
                var next = NextPosition(n, new[] { r, c }, ref D);
                if ((next[0] != lastR || next[1] != lastC) && board[next[0]][next[1]] == '*')
                {
                    if (d == ' ')
                        d = D == '>' ? '<' : D == '<' ? '>' : D == '^' ? 'v' : '^';
                    snake.AddLast(next);
                    lastR = r;
                    lastC = c;
                    r = next[0];
                    c = next[1];
                    goto Seek;
                }
            }
            return snake;
        }

        void Execute(char[][] board, char command, LinkedList<int[]> snake, ref char d)
        {
            var u = snake.First.Value;
            if (board[u[0]][u[1]] != 'x')
            {
                switch (command)
                {
                    case 'R':
                        TurnRight(board, snake, d);
                        break;
                    case 'L':
                        TurnLeft(board, snake, d);
                        break;
                    case 'F':
                        d = Advance(board, snake);
                        break;
                }
            }
        }

        void TurnRight(char[][] board, LinkedList<int[]> snake, char d)
        {
            var u = snake.First.Value;
            int headR = u[0], headC = u[1];
            switch (d)
            {
                case '^':
                    board[headR][headC] = '>';
                    break;
                case '>':
                    board[headR][headC] = 'v';
                    break;
                case 'v':
                    board[headR][headC] = '<';
                    break;
                case '<':
                    board[headR][headC] = '^';
                    break;
            }
        }

        void TurnLeft(char[][] board, LinkedList<int[]> snake, char d)
        {
            var u = snake.First.Value;
            int headR = u[0], headC = u[1];
            switch (d)
            {
                case '^':
                    board[headR][headC] = '<';
                    break;
                case '<':
                    board[headR][headC] = 'v';
                    break;
                case 'v':
                    board[headR][headC] = '>';
                    break;
                case '>':
                    board[headR][headC] = '^';
                    break;
            }
        }

        int[] NextPosition(int n, int[] p, ref char d)
        {
            int r = p[0], c = p[1];
            switch (d)
            {
                case '<':
                    if (c < 1)
                        c = 4 * n - 1;
                    else if (c > n || r >= n && r < n + n)
                        c--;
                    else if (c == n)
                    {
                        if (r < n)
                        {
                            c = r;
                            r = n;
                            d = 'v';
                        }
                        else
                        {
                            c = 3 * n - 1 - r;
                            r = n + n - 1;
                            d = '^';
                        }
                    }
                    break;
                case '>':
                    if (c == 4 * n - 1)
                        c = 0;
                    else if (c < n + n - 1 || r >= n && r < n + n)
                        c++;
                    else if (c == n + n - 1)
                    {
                        if (r < n)
                        {
                            c += n - r;
                            r = n;
                            d = 'v';
                        }
                        else
                        {
                            c = r;
                            r = n + n - 1;
                            d = '^';
                        }
                    }
                    break;
                case '^':
                    if (r < 1)
                    {
                        r = n;
                        c = 5 * n - 1 - c;
                        d = 'v';
                    }
                    else if (r > n || c >= n && c < n + n)
                        r--;
                    else if (r == n)
                    {
                        if (c < n)
                        {
                            r = c;
                            c = n;
                            d = '>';
                        }
                        else if (c < 3 * n)
                        {
                            r = 3 * n - 1 - c;
                            c = n + n - 1;
                            d = '<';
                        }
                        else
                        {
                            r = 0;
                            c = 5 * n - 1 - c;
                            d = 'v';
                        }
                    }
                    break;
                case 'v':
                    if (r == 3 * n - 1)
                    {
                        r = n + n - 1;
                        c = 5 * n - 1 - c;
                        d = '^';
                    }
                    else if (r < n + n - 1 || c >= n && c < n + n)
                    {
                        r++;
                    }
                    else if (r == n + n - 1)
                    {
                        if (c < n)
                        {
                            r += n - c;
                            c = n;
                            d = '>';
                        }
                        else if (c < 3 * n)
                        {
                            r = c;
                            c = n + n - 1;
                            d = '<';
                        }
                        else
                        {
                            r += n;
                            c = r + n + n - c;
                            d = '^';
                        }
                    }
                    break;
            }
            return new[] { r, c };
        }

        char Advance(char[][] board, LinkedList<int[]> snake)
        {
            int n = board.Length / 3;
            var u = snake.First.Value;
            char d = board[u[0]][u[1]];
            var p = NextPosition(n, u, ref d);
            var c = board[p[0]][p[1]];
            if (c == '*')
            {
                Die(board, snake);
                d = 'x';
            }
            else
            {
                board[u[0]][u[1]] = '*';
                if (c != 'o')
                {
                    u = snake.Last.Value;
                    board[u[0]][u[1]] = '_';
                    snake.RemoveLast();
                }
                board[p[0]][p[1]] = d;
                snake.AddFirst(p);
            }
            return d;
        }

        void Die(char[][] board, LinkedList<int[]> snake)
        {
            foreach (var u in snake)
            {
                board[u[0]][u[1]] = 'x';
            }
        }
    }
}
