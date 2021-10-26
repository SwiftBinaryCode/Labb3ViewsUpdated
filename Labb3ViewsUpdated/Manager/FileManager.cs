using Labb3ViewsUpdated.Mvvm.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Labb3ViewsUpdated.Manager
{
    class FileManager
    {
        public static List<Quiz> _availableQuizzes = new List<Quiz>();

        public static string _path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string _pathName = "QuizList.json";

        public List<Quiz> Quizzes
        {
            get { return _availableQuizzes; }
            set { _availableQuizzes = value; }

        }

        public FileManager()
        {

        }

        public static async Task SaveQuiz(List<Quiz> availibleQuizzes)
        {

            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(_path, _pathName)))
            {

                await streamWriter.WriteAsync(JsonSerializer.Serialize(_availableQuizzes));

            }

        }

        public static List<Quiz> LoadQuiz()
        {

            using (var streamReader = new StreamReader(Path.Combine(_path, _pathName)))
            {
                var Text = streamReader.ReadToEnd();

                List<Quiz> listOfQuizzes = JsonSerializer.Deserialize<List<Quiz>>(Text);
                return listOfQuizzes;

            }


        }

    }
}
