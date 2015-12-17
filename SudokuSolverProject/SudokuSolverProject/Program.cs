using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolverProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //new SudokuSolver("850002400" + "720000009" + "004000000" + "000107002" + "305000900" + "040000000" + "000080070" + "017000000" + "000036040").Solve();
            //new SudokuSolver("200080300" + "060070084" + "030500209" + "000105408" + "000000000" + "402706000" + "301007040" + "720040060" + "004010003").Solve();
            new SudokuSolver("200080300060070084030500209000105408000000000402706000301007040720040060004010003").Solve();
            Console.Read();
        }
    }
}
