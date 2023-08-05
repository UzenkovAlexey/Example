// Работа с текстомю
// Дан текст
// B тексте нужно все пробелы заменить черточками
// Mаленькие буквы "к" заменить на большие "К"
// Большие "С" заменить на меленькие "с"

string text = " - Я думаю, сказал князь, улыбаясь, - что,"
                + "ежели бы вас послали вместо нашего Винценгероде,"
                + "вы бы взяли приступо согласие прусского короля."
                + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s[3] // r 



string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    
    for (int i = 0; i < length; i++)

    {
        
        if (text[i] == oldValue) result = result + $"{newValue}";
        
        else result = result + $"{text[i]}";
    }
    return result;
}       
string  newText = Replace(text, ' ', 'у');

Console.WriteLine(newText); 

Console.WriteLine(); 

newText = Replace(newText, 'а', 'ы');

Console.WriteLine(newText);
 
     