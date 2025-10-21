using UnityEngine;
using TMPro;

public class testie : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI week;
    public TextMeshProUGUI date;
    public TextMeshProUGUI season;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        text.text = WHATEVERYOUWANTFORNOW.gold.ToString();
        text2.text = WHATEVERYOUWANTFORNOW.actions.ToString();
        date.text = WHATEVERYOUWANTFORNOW.date.ToString();

        if (WHATEVERYOUWANTFORNOW.week == 1) 
        {
            week.text = "Monday";
        }
        if (WHATEVERYOUWANTFORNOW.week == 2) 
        {
            week.text = "Tuesday";
        }
        if (WHATEVERYOUWANTFORNOW.week == 3) 
        {
            week.text = "Wednesday";
        }
        if (WHATEVERYOUWANTFORNOW.week == 4)
        {
            week.text = "Thursday";
        }
        if (WHATEVERYOUWANTFORNOW.week == 5) 
        {
            week.text = "Friday";
        }

        if (WHATEVERYOUWANTFORNOW.season == 1) 
        {
            season.text = "SPRING";
        }
        
    }
}
