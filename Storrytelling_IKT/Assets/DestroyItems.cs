using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
        }
    }
}
