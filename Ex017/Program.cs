/* Для работы с директориями */
string path = "/Users/ybiryukov/Desktop/Git/Ex001";
DirectoryInfo di = new DirectoryInfo(path); // Указал путь, например, к Ex001
Console.WriteLine(di.CreationTime); // дата создания папки
FileInfo[] files = di.GetFiles();
for (int i = 0; i < files.Length; i++)
{
    Console.WriteLine(files[i].Name);
}

void CatalogInfo(string path, string indent = "") // путь и отступы
{
    DirectoryInfo catalog = new DirectoryInfo(path); // инфо о директории
    DirectoryInfo[] catalogs = catalog.GetDirectories(); // массив всех директорий
    for (int i = 0; i < catalogs.Length; i++) // весь вывод папок
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles(); /* весь список файлов в
                                            * текущей директории */
    for(int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path1 = "/Users/ybiryukov/Desktop/Git/Ex001";
CatalogInfo(path1);