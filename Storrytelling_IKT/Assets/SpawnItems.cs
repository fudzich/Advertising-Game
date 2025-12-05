using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItems : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private float spawnCounter;
    private float tSpawnCounter;

    // Start is called before the first frame update
    void Start()
    {
            //tSpawnCounter = spawnCounter;
    }

    private void Awake()
    {
        spawnCounter = Random.Range(0.1f, 3.1f);
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
                
                if (item != null)
                {
                    Instantiate(item, transform.position, transform.rotation);
                }
            }
            
        }
    }

    private bool sucessCheck(){
        int randomNumber = Random.Range(0, 100);
        Debug.Log(randomNumber);
        return randomNumber > 60;
    }
}
