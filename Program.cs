Console.Clear();
Console.WriteLine("Привет! Эта программа берет массив строк и формирует из него другой массив строк, элементы которого не длиннее трёх символов.");
Console.WriteLine();

string[] FindElements(string[] originalArray) {
    int count = 0;
    for(int i = 0; i < originalArray.Length; i++) {
        if(originalArray[i].Length <= 3) {
            count++;
        }
    }

    string[] newArray = new string[count];
    int j = 0;
    for(int i = 0; i < originalArray.Length; i++) {
        if(originalArray[i].Length <= 3) {
            newArray[j] = originalArray[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] finalArray) {
    Console.WriteLine();
    Console.Write("Итоговый массив: ");
    for(int i = 0; i < finalArray.Length; i++) {
        if(i < finalArray.Length - 1) {
            Console.Write($"{finalArray[i]}, ");
        }
        else {
            Console.Write($"{finalArray[i]}.");
        }
    }
}

string[] array = new string[6] {"Saint-Petersburg", "123", "Long", ":D", "Excelsior", "1234"};

Console.Write("Изначальный массив: ");
for(int i = 0; i < array.Length; i++) {
    if(i < array.Length - 1) {
        Console.Write($"{array[i]}, ");
    }
    else {
        Console.Write($"{array[i]}.");
    }
}
Console.WriteLine();

PrintArray(FindElements(array));