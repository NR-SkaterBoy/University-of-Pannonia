/**
 * Készíts egy függvényt ParosokOsszege néven, amely paraméterül egész számok tömbjét kapja, és visszaadja a páros elemek összegét!
 *
 * Test:    int[] tomb = {8,4,1,4,6,8,4,2,8};
 *          int osszeg = ParosokOsszege(tomb);
 *          Console.WriteLine(osszeg);
 * Result:  44
 */

// Elso megoldas
static int ParosokOsszege(int[] tomb)
{
    int p = 0;
    foreach (int e in tomb)
    {
        if (e % 2 == 0)
            p += e;
    }
    return p;
}

// Masodik megoldas
// Ezen módszerhez szükséges importálni a System.Linq namespace-t
static int ParosokOsszege(int[] tomb)
{
    return tomb.Where(e => e % 2 == 0).Sum();
}
