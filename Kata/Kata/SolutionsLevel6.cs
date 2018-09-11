namespace Kata.Level6
{
    public class SolutionsLevel6
    {
        public static string[] TowerBuilder(int nFloors)
        {
            string[] floors = new string[nFloors];
            for (var i = 1; i <= nFloors; i++)
            {
                var spaces = new string(' ', nFloors - i);
                var stars = new string('*', (i * 2) - 1);
                var floor = string.Concat(spaces, stars, spaces);
                floors[i - 1] = floor;
            }
            return floors;
        }
    }
}