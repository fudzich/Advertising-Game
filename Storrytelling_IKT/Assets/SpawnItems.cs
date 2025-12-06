using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{

    [Header("Milk")]
    [SerializeField] private GameObject milk;
    [SerializeField] private GameObject chese;
    [SerializeField] private GameObject icecream;

    [Header("Fish")]
    [SerializeField] private GameObject fish;
    [SerializeField] private GameObject shrimp;
    [SerializeField] private GameObject squid;

    [Header("Meat")]
    [SerializeField] private GameObject meat;
    [SerializeField] private GameObject beacon;
    [SerializeField] private GameObject sausage;

    [Header("Cooked")]
    [SerializeField] private GameObject burger;
    [SerializeField] private GameObject salad;
    [SerializeField] private GameObject sub;

    [Header("Veges")]
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject carrot;
    [SerializeField] private GameObject tomato;
    
    
    private float spawnCounter;
    private float tSpawnCounter;
    private GameObject item;
    // Start is called before the first frame update
    
    void Start()
    {
            //tSpawnCounter = spawnCounter;
    }

    private void Awake()
    {
        spawnCounter = Random.Range(0.5f, 3.1f);
        tSpawnCounter = spawnCounter;
    }
    // Update is called once per frame
    void Update()
    {
        tSpawnCounter -= Time.deltaTime;
        if (tSpawnCounter <= 0f)
        {
            tSpawnCounter = spawnCounter;
            
            if(sucessCheck()){
                
                string itemCategory = randomItemCategory();
                //GameObject item;

                switch (itemCategory)
                {
                    case "milk":
                        item = randomMilk();
                        break;
                    case "fish":
                        item = randomFish();
                        break;
                    case "meat":
                        item = randomMeat();
                        break;
                    case "cooked":
                        item = randomCooked();
                        break;
                    case "veges":
                        item = randomVeges();
                        break;
                }

                if (item != null)
                {
                    Instantiate(item, transform.position, transform.rotation);
                }
            }
            
        }
    }

    private bool sucessCheck(){
        int randomNumber = Random.Range(0, 100);
        return randomNumber > 60;
    }

    private string randomItemCategory(){
        int randomNumber = Random.Range(1, 6);
        if(randomNumber == 1){
            return "milk";
        }
        else if(randomNumber == 2){
            return "fish";
        }
        else if(randomNumber == 3){
            return "meat";
        }
        else if(randomNumber == 4){
            return "cooked";
        }
        else{
            return "veges";
        }
    }

    private GameObject randomMilk(){
        int randomNumber = Random.Range(1, 4);
        if(randomNumber == 1){
            return milk;
        }
        else if(randomNumber == 2){
            return chese;
        }
        else{
            return icecream;
        }
    }

    private GameObject randomFish(){
        int randomNumber = Random.Range(1, 4);
        if(randomNumber == 1){
            return fish;
        }
        else if(randomNumber == 2){
            return shrimp;
        }
        else{
            return squid;
        }
    }

    private GameObject randomMeat(){
        int randomNumber = Random.Range(1, 4);
        if(randomNumber == 1){
            return meat;
        }
        else if(randomNumber == 2){
            return beacon;
        }
        else{
            return sausage;
        }
    }

    private GameObject randomCooked(){
        int randomNumber = Random.Range(1, 4);
        if(randomNumber == 1){
            return salad;
        }
        else if(randomNumber == 2){
            return sub;
        }
        else{
            return burger;
        }
    }

    private GameObject randomVeges(){
        int randomNumber = Random.Range(1, 4);
        if(randomNumber == 1){
            return tomato;
        }
        else if(randomNumber == 2){
            return apple;
        }
        else{
            return carrot;
        }
    }
}
