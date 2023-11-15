// Вид 1 - ничего не принимают, ничего не возвращают
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1(); 




// Вид 2 - что-то принимают, ничего не возвращают
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg:"Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i ++;
    }
}
// Method21(msg: "Текст",count: 4);
// Method21(count: 4, msg: "Новый текст"); // Именованные аргументы не обязательно указывать по порядку

// Вид 3 - ничего не принимают, что-то возвращают
int Method3() // обязательно указываем тип данных, значение которого мы ожидаем
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);


// Вид 4 - что-то принимают, что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while( i < count)
    {
        result = result + text;
        i++;
    }
    return result;     
}
string res = Method4(10, "z");
Console.WriteLine(res);