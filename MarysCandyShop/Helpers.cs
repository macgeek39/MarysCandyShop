namespace MarysCandyShop;

internal static class Helpers
{
    internal static int GetDaysSinceOpening()
    {
        var openingDate = new DateTime(2024, 1, 1);
        var days = DateTime.Now - openingDate;

        return days.Days;
    }
}
