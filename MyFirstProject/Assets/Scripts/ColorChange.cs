using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    int count = 0;
 
    private void Update()
    {
     
        if (count % 200 == 0)
        {
            GetComponent<Renderer>().sharedMaterial.color = Random.ColorHSV();

        }
        count++;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
