using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TireMove : MonoBehaviour
{
    bool hasMoved = false; // keep track of whether the object has already moved

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasMoved && Input.GetMouseButtonDown(0)) // check if left mouse button is pressed and the object hasn't moved yet
        {
            // move the object forward by 1 unit in the y-axis direction
            transform.Translate(Vector3.up * -3f);
            hasMoved = true; // set the boolean variable to true to indicate that the object has moved
        }
    }

    void OnMouseDown()
    {
        // create a dialog box and display information about the tire
        GUI.Box(new Rect(20, 20, 200, 50), "Tire Information\nSize: 225/45R17\nBrand: Goodyear\nModel: Eagle F1 Asymmetric");
    }
}
