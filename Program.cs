// Напишите программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно задать или ввести с клавиатуры.

string[] array = new string[]{
        "1S01", "1S01", "1S01", "1S01", "1S01", "1S02", "1S02",
        "1S02", "1H01", "1H01", "1S02", "1S01", "1S01", "1H01",
        "1H01", "1H01", "1S02", "Юля", "1M02", "1M02", "1M02"};

Console.WriteLine("[" + string.Join(", ", array) + "]");

void SelectThreeSymbol(string[] array) {
    int lenOfarray = array.Length;
    int count = 3; // magic number of symbol form the task
    string[] arrayTemp = new string[lenOfarray];
    int countOfString = 0;
    for(int i = 0; i < lenOfarray; i++) {
        if(array[i].Length <= count) {
            arrayTemp[countOfString] = array[i];
            countOfString++;
        }
    }
    Console.WriteLine("[" + string.Join(", ", arrayTemp) + "]");
}

SelectThreeSymbol(array);
