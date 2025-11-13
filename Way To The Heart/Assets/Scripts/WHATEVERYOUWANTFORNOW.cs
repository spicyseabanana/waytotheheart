using UnityEngine;

public static class WHATEVERYOUWANTFORNOW
{
    // actions left
    // things needed: create an "action"
    // when an "action" is performed, the current # of actions minus 1
    // when action value=0, trigger the end of the day cutscene, increase the "week" and "date" values by 1, and reset action count
    public static int actions = 0;
   
    // day of the week
    // when action value is 0, increase the week value by 1
    // when action value is greater than 7, reset to 1.
    // assign weekdays to each number.
    public static int week = 7;
    // day of the season
    // when action value=0, increase the date value by 1
    // when week is greater than 30, trigger the end of season cutscene, increase the season value by 1, and reset date to 1
    public static int date = 30;
    // season of the year
    // assign each number to a different season (Spring, Summer, Fall, Winter)
    // when date is greater than 30, increase the season value by 1
    public static int season = 1;
    // time of day
    // assign each number to a different time of day (Morning, Noon, Afternoon, Evening)
    // when action value is 10, 11, or 12 = 1
    // when action value is 7, 8, or 9 = 2
    // when action value is 4, 5, 6 = 3
    // when action value is 1, 2, 3 = 4
    public static int time = 2;
    // amount of gold
    public static int gold = 0;
    
    public static void ActionCheck()
    {
        if (actions == 0)
        {
            week = week + 1;
            date = date + 1;
            actions = 12;
        }
    }
    public static void WkCheck()
    {
        if (week > 7)
        {
            week = 1;
        }
    }

    public static void DateCheck()
    {
        if (date > 30)
        {
            date = 1;
            season = season + 1;
        }
    }
    
    public static void TimeCheck()
    {
        if (actions > 9)
        {
            time = 1;
        }
        if (actions < 10 && actions > 6)
        {
            time = 2;
        }
        Debug.Log("timecheck ran");
    }
}
