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

        public static bool IsValidIP(string ipAddress)
        {
            var splitted = ipAddress.Split('.');
            var result = splitted.Length == 4 && !ipAddress.Contains(" ");

            foreach (var item in splitted)
            {
                result &= int.TryParse(item, out var parsed)
                    && parsed >= 0
                    && parsed <= 255;

                if (item.StartsWith("0") && item.Length > 1)
                {
                    result = false;
                }
            }
            return result;

            // alternative
            //IPAddress ip;
            //bool validIp = IPAddress.TryParse(ipAddress, out ip);
            //return validIp && ip.ToString() == ipAddress;
        }
    }
}