using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchItems : MonoBehaviour
{
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(points);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("item"))
        {
            Destroy(other.gameObject);
            points+=50;
        }
    }
}
