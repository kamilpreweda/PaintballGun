
int numberOfBalls = ReadInt(20, "Liczba kulek");
int magazineSize = ReadInt(16, "Pojemność magazynka");
Console.Write($"Załadowany [false]: ");
bool.TryParse(Console.ReadLine(), out bool isLoaded);



PaintballGun.PaintballGun gun = new PaintballGun.PaintballGun(numberOfBalls, magazineSize, isLoaded);

while (true)
{
    Console.WriteLine($"Kulki: {gun.Balls}, załadowano: {gun.BallsLoaded}");
    if (gun.IsEmpty()) Console.WriteLine("OSTRZEŻENIE: brak amunicji");
    Console.WriteLine("[Spacja] - strzał, [p] - przeładowanie, " + "[+] - dodaj amunicje, [k] - koniec");
    char key = Console.ReadKey(true).KeyChar;
    if (key == ' ') Console.WriteLine($"Próba strzału: {gun.Shoot()}");
    else if (key == 'p') gun.Reload();
    else if (key == '+') gun.Balls += gun.MagazineSize;
    else if (key == 'k') return;
}

static int ReadInt(int lastUsedValue, string prompt)
{
    Console.WriteLine(prompt + " [Wartość domyślna: " + lastUsedValue.ToString() + " ]");
    Console.Write($"Wpisz {prompt}: ");
    bool IsuserInputValid = int.TryParse(Console.ReadLine(), out int userInput);
    if (IsuserInputValid)
    {
        Console.WriteLine($"Użycie wartości: {userInput}");
        return userInput;
    }
    else
    {
        Console.WriteLine($"Użycie wartości domyślnej: {lastUsedValue}");
        return lastUsedValue;
    }

}
