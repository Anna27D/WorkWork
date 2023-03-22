// Описание рекурсии, которая будет ходить по папкам и смотреть их содержимое.

void CatalogInfo(string path, string indent = "") // первый аргумент - путь к текущей папке, второй - искусственный прием, позволяющий делать отступы, чтобы видеть стр-ру папки
{
    {
        DirectoryInfo catalog = new DirectoryInfo(path); // получаем информацию о той директории, в которую мы зашли

        DirectoryInfo[] catalogs = catalog.GetDirectories(); // получаем массив всех файлов, находящихся в этой папке
        for (int i = 0; i < catalogs.Length; i++)            // пробегаем по ним, 
        {
            Console.WriteLine($"{indent}{catalogs[i].Name}"); // и выводя информацию о текущем каталоге
            CatalogInfo(catalogs[i].FullName, indent + " ");  // мы будем рекурсивно заныривать и смотреть все папки, кот. будут получены на данном этапе
        }
    }

    FileInfo[] files = catalog.GetFiles(); // перейдем и получим весь список файлов текущей директории

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}"); // и покажем их
    }
}

string path = @"Homework\Homework_01\Ex01";
CatalogInfo(path);

// не работает