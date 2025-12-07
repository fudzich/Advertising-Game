using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText; 
    [SerializeField] private TextMeshProUGUI categoryText;
    [SerializeField] private TextMeshProUGUI percentText;

    [Header("QR Images")]
    [SerializeField]
    GameObject cookQR;
    [SerializeField]
    GameObject fishQR;
    [SerializeField]
    GameObject meatQR;
    [SerializeField]
    GameObject milkQR;
    [SerializeField]
    GameObject vegeQR;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScoreUI();
        UpdateCategoryUI();
        UpdatePercentUI();

        Debug.Log(DataHolder.points);

        Debug.Log("рыба " + DataHolder.fishPoints);
        Debug.Log("мясо " +DataHolder.meatPoints);
        Debug.Log("овощи " +DataHolder.vegesPoints);
        Debug.Log("готовая " +DataHolder.cookedPoints);
        Debug.Log("молоко " +DataHolder.milkPoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null){
            int score = DataHolder.points;
            scoreText.text = score.ToString();
        }
    }

    private void UpdateCategoryUI()
    {
        if (categoryText != null){
            string category = HighestCategoryScore();
            categoryText.text = category;
        }
    }

    private void UpdatePercentUI()
    {
        if (scoreText != null){
            int score = DataHolder.points;
            score = score/100;
            if(score > 6) score = 6;
            percentText.text = string.Format("{0}%", score);
        }
    }

    private string HighestCategoryScore(){
        string answer = "Рыба и Морепродукты";
        int maxValue = DataHolder.fishPoints;
        fishQR.SetActive(true);  

        if(maxValue < DataHolder.meatPoints){
            answer = "Мясо, Птица, Колбасы";
            maxValue = DataHolder.meatPoints;
            meatQR.SetActive(true); 
        }
        if(maxValue < DataHolder.vegesPoints){
            answer = "Овощи, Фрукты, Орехи";
            maxValue = DataHolder.vegesPoints;
            vegeQR.SetActive(true); 
        }
        if(maxValue < DataHolder.cookedPoints){
            answer = "Готовая Еда";
            maxValue = DataHolder.cookedPoints;
            cookQR.SetActive(true); 
        }
        if(maxValue < DataHolder.milkPoints){
            answer = "Молочная Продукция";
            maxValue = DataHolder.milkPoints;
            milkQR.SetActive(true); 
        }

        return answer;
    }
}
