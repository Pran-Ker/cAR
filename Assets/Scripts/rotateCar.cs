using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    float degreesPerSecond = 20;
private void Update()
{
    transform.Rotate(new Vector3(0, degreesPerSecond, 0) * Time.deltaTime);
}
}
