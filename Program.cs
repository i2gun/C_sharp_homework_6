// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
//            сколько чисел больше 0 ввёл пользователь.
//            (we assume that entered numbers are integer)
int countZeros = 0;
int num;
string Result = "";
bool firstEntry = true;

Console.Write("Enter a number: ");

while (Int32.TryParse(Console.ReadLine(), out num)) {
    if (num > 0) countZeros++;
    if (firstEntry) {
        Result += num;
        firstEntry = false;
    } else Result = Result + ", " + num;

    Console.Write("Enter the next number: ");
}
Console.WriteLine(Result + " -> " + countZeros);

// Задача 43: Найти точку пересечения двух прямых, заданных
//            уравнениями y = k1 * x + b1, y = k2 * x + b2;
//            значения b1, k1, b2 и k2 задаются пользователем.

double b1, k1, b2, k2;
Console.Write("Enter a number b1: ");
while (!double.TryParse(Console.ReadLine(), out b1)) {
    Console.Write("That is not a number. Enter a number b1: ");
}
Console.Write("Enter a number k1: ");
while (!double.TryParse(Console.ReadLine(), out k1)) {
    Console.Write("That is not a number. Enter a number k1: ");
}
Console.Write("Enter a number b2: ");
while (!double.TryParse(Console.ReadLine(), out b2)) {
    Console.Write("That is not a number. Enter a number b2: ");
}
Console.Write("Enter a number k2: ");
while (!double.TryParse(Console.ReadLine(), out k2)) {
    Console.Write("That is not a number. Enter a number k2: ");
}

if (k1 == k2) {
    if (b1 == b2) {
        Console.Write("Two lines are the same. " +
                        "Infinite number of intersection points.");
    } else Console.Write("Two lines are parallel. " +
                                        "No intersection points.");
} else {
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;

    Console.Write("b1 = {0:f2}, k1 = {1:f2}, b2 = {2:f2}, " +
            "k2 = {3:f2} -> ({4:f2}; {5:f2})", b1, k1, b2, k2, x, y);
}