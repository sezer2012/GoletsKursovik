using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GoletsKursovik
{
    public static class GlobalConfig
    {
        // Статическая переменная для хранения пути к базе данных
        public static string DatabasePath { get; set; }

        // Метод для вычисления пути к базе данных
        public static void SetDatabasePath()
        {
            if (string.IsNullOrEmpty(DatabasePath))
            {
                // Получаем путь к текущей директории проекта
                string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName;

                // Строим путь к базе данных
                string diskLetter = Path.GetPathRoot(projectDirectory);
                string relativePath = Path.Combine(diskLetter, "Курсач", "Database.accdb");

                // Записываем его в переменную
                DatabasePath = relativePath;
            }
        }
    }
}
