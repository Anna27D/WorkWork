// Как посмотреть содержимое папки.

string path = "Lecture/Lecture_02/example009_IntroArray"; // скопировали путь к нужной папке
DirectoryInfo di = new DirectoryInfo(path); // указать путь к той папки, свойства которой хотим посмотреть
Console.WriteLine(di.CreationTime); // через "di.параметр" посмотреть информацию (дату и время создания)
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    Console.WriteLine(fi[i].Name);
}
