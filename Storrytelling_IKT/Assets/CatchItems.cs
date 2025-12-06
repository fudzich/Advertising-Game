using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchItems : MonoBehaviour
{
    public int points;

    public int milkPoints;
    public int fishPoints;
    public int meatPoints;
    public int vegesPoints;
    public int cookedPoints;
    
    // Start is called before the first frame update
    void Start()
    {
        DataHolder.points = 0;

        DataHolder.milkPoints = 0;
        DataHolder.fishPoints = 0;
        DataHolder.meatPoints = 0;
        DataHolder.vegesPoints = 0;
        DataHolder.cookedPoints = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("milk") || other.CompareTag("fish") || other.CompareTag("meat") || other.CompareTag("cooked") || other.CompareTag("veges"))
        {
            Destroy(other.gameObject);
            DataHolder.points+=5;
        }

        switch(other.tag){
            case "milk":
                DataHolder.milkPoints +=1;
                break;
            case "meat":
                DataHolder.meatPoints +=1;
                break;
            case "veges":
                DataHolder.vegesPoints +=1;
                break;
            case "cooked":
                DataHolder.cookedPoints +=1;
                break;
            case "fish":
                DataHolder.fishPoints +=1;
                break;
        }
    }
}
