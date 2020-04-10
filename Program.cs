using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task6, string> TaskSolver = task =>
            {
                string pathToParkImage = Task6.PathToParkImage;
                string pathToLogs = "";

                return pathToLogs;
            };
            Task6.CheckSolver(TaskSolver);
        }
    }
}
