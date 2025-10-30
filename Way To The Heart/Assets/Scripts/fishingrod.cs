using UnityEngine;
using UnityEngine.UI;

public class fishingrod : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image fishrod;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = Input.mousePosition;
    }
}
