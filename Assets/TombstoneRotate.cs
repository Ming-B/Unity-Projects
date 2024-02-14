using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TombstoneRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float xRotate = Mathf.Lerp(0f,45.0f,Time.deltaTime);
        transform.Rotate(xRotate, 0, 0);
        
    }
}
