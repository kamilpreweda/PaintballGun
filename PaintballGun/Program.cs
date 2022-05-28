PaintballGun.PaintballGun gun = new PaintballGun.PaintballGun();

while (true)
{
    Console.WriteLine($"Kulki: {gun.Balls}, załadowano: {gun.BallsLoaded}");
    if (gun.IsEmpty()) Console.WriteLine("OSTRZEŻENIE: brak amunicji");
    Console.WriteLine("[Spacja] - strzał, [p] - przeładowanie, " + "[+] - dodaj amunicje, [k] - koniec");
    char key = Console.ReadKey(true).KeyChar;
    if (key == ' ') Console.WriteLine($"Próba strzału: {gun.Shoot()}");
    else if (key == 'p') gun.Reload();
    else if (key == '+') gun.Balls += PaintballGun.PaintballGun.MAGAZINE_SIZE;
    else if (key == 'k') return;
}
