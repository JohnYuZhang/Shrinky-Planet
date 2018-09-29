using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class shrinkGrow : MonoBehaviour {

    public float maxSize = 1f;
    public float minSize = 0.5f;
    public float speed = 0.6f;

    // Update is called once per frame
    void Update() {
        Vector3 lTemp = transform.localScale;

        var range = maxSize - minSize;
        
        lTemp.x = (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f * range + minSize;
        lTemp.y = (Mathf.Sin(Time.time * speed) + 1.0f) / 2.0f * range + minSize;
       
        transform.localScale = lTemp;
    }
}
