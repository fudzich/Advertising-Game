using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoseFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the mouse position in screen space
        Vector3 mouseScreenPosition = Input.mousePosition;
        
        // Convert mouse position to world space
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(mouseScreenPosition);
        
        // Keep the current y and z positions
        Vector3 newPosition = new Vector3(mouseWorldPosition.x, transform.position.y, transform.position.z);
        
        // Set the object's position to follow the mouse on x-axis
        transform.position = newPosition;
    }
}
