for(var i = 0; i <= 10; i++)
{
    Console.WriteLine(i);
    for (var j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк
    }
}


// Задание. Дан текст, надо заменить все пробелы черточками и один символ заменить другим
string str = "AddBusinessProcess(BaseCard, Guid, KindsCardProcess)\tДобавляет к карточке бизнес-процесс с переданным идентификатором.\r\nAddSignature(SignatureList, X509Certificate2, String, StatesState)\tДобавляет в переданный список подписей ЭЦП.\r\nAddSignaturePart(BaseCardSignature, Guid, Byte[], String, Guid, Guid, BaseCard)\tИнициализирует и добавляет в указанную подпись часть подписи.\r\nAddSignaturePart(BaseCardSignature, Guid, Byte[], String, Guid, Guid, BaseCard, DateTime?, BaseCardSignaturePartStatus)\tИнициализирует и добавляет в указанную подпись часть подписи, прошедшую проверку валидности.";

string Replase(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    for (var i = 0; i < text.Length; i++)
    {
        if (text[i] == oldValue)
        {
            result += $"{newValue}";
        }
        else
        {
            result += $"{str[i]}";
        }
    }
    return result;
}

string newText = Replase(str, ' ', '-'); // char '', string ""
Console.WriteLine(newText);
// далее еще раз можем метод использовать, он поменяет символы в уже отредактированном тексте