using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class testie : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI week;
    public TextMeshProUGUI date;
    public TextMeshProUGUI season;
    public Image time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Daytime();
    }
    
    void Daytime()
    {
        Sprite MORNING = Resources.Load<Sprite>("time1");
        Sprite NOON = Resources.Load<Sprite>("time2");

        if (WHATEVERYOUWANTFORNOW.time == 1)
        {
            gameObject.GetComponent<Image>().sprite = MORNING;
        }
        if (WHATEVERYOUWANTFORNOW.time == 2)
        {
            gameObject.GetComponent<Image>().sprite = NOON;
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = WHATEVERYOUWANTFORNOW.gold.ToString();
        text2.text = WHATEVERYOUWANTFORNOW.actions.ToString();
        date.text = WHATEVERYOUWANTFORNOW.date.ToString();

        Daytime();

        if(WHATEVERYOUWANTFORNOW.week == 1) 
        {
            week.text = "Monday";
        }
        if(WHATEVERYOUWANTFORNOW.week == 2) 
        {
            week.text = "Tuesday";
        }
        if(WHATEVERYOUWANTFORNOW.week == 3) 
        {
            week.text = "Wednesday";
        }
        if(WHATEVERYOUWANTFORNOW.week == 4)
        {
            week.text = "Thursday";
        }
        if(WHATEVERYOUWANTFORNOW.week == 5) 
        {
            week.text = "Friday";
        }

        if(WHATEVERYOUWANTFORNOW.season == 1) 
        {
            season.text = "SPRING";
        }
        
    }
}
