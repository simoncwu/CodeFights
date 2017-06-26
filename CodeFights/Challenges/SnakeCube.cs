using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFights.CSharp.Challenges
{
    /// <summary>
    /// Solution for CodeFights challenge "snakeCube": 
    /// https://codefights.com/challenge/93CBnFa2vWyivpdHE
    /// 
    /// This challenge is a modified version of the classic Snake game. Instead 
    /// of a 2-D rectangle, the board is now the surface of a 3-D cube. When 
    /// the snake passes the edge of one surface, it will wrap around to the 
    /// adjacent surface. If the snake touches itself, it dies.
    /// 
    /// There are also some apples on the cube that, when touched, will 
    /// increase the length of the snake by one unit and then disappear.
    /// 
    /// Given the initial board state, move the Snake according to a list of 
    /// commands and return the final state of the board. If the snake dies 
    /// during this process, return the state of the board right before the 
    /// snake overlaps itself and replace the snake body with 'x's.
    /// 
    /// It is guaranteed that each cell of the snake's body has no more than 2 
    /// adjacent cells that are also occupied by the snake.
    /// 
    /// The commands are given as a string, where each character is a command. 
    /// The possible commands are:
    /// F: move one unit forward in the direction of the Snake head;
    /// R: rotate Snake head 90° right;
    /// L rotate Snake head 90° left.
    /// 
    /// The snake cannot rotate its neck past 90° in either direction, so 
    /// hyperextending L and R commands should be ignored. For example, 
    /// commands FR, FRR and FLRR will all result in a final head rotation to 
    /// the right.
    /// 
    /// If the snake dies, output its body before the final move as x's.
    /// </summary>
    public class SnakeCube
    {
        /// <summary>
        /// Returns the state of a 3-dimensional version of the game Snake after a sequence of moves.
        /// </summary>
        /// <param name="board">A rectangular matrix representing the game board as a cube net.</param>
        /// <param name="commands">A string of characters indicating the moves to make.</param>
        /// <returns>The state of <paramref name="board"/> after executing <paramref name="commands"/>.</returns>
        public char[][] snakeCube(char[][] board, string commands)
        {
            // track the state of the head across commands
            char direction;
            // parse the board for the snake's initial position
            var snake = FindSnake(board, out direction);
            foreach (var c in commands)
            {
                Execute(board, c, snake, ref direction);
                // terminate processing once dead
                if (direction == 'x')
                    break;
            }
            return board;
        }

        /// <summary>
        /// Parses a 3-D snake game board for the snake's position and returns it.
        /// </summary>
        /// <param name="board">A rectangular matrix representing the game board as a cube net.</param>
        /// <param name="direction">When this method returns, contains the character indicating the direction of the snake head. This parameter is passed uninitialized; any value originally supplied will be overwritten.</param>
        /// <returns>A <see cref="LinkedList{T}"/> of two-element arrays indicating the row and column indices of each segment of the snake.</returns>
        LinkedList<int[]> FindSnake(char[][] board, out char direction)
        {
            var snake = new LinkedList<int[]>();
            direction = ' ';

            // find position of snake head
            int r = -1, c = r, n = board.Length / 3;
            while (c < 0)
            {
                c = Array.FindIndex(board[++r], _ => "^>v<".Contains(_));
            }
            snake.AddLast(new[] { r, c });

            int lastR = r, lastC = c;
            Seek:
            foreach (var head in "<>^v")
            {
                var D = head;
                var next = NextPosition(n, new[] { r, c }, ref D);
                if ((next[0] != lastR || next[1] != lastC) && board[next[0]][next[1]] == '*')
                {
                    if (direction == ' ')
                        direction = D == '>' ? '<' : D == '<' ? '>' : D == '^' ? 'v' : '^';
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
