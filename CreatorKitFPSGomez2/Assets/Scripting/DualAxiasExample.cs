using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualAxiasExample : MonoBehaviour
{
 
    public float hRange;
    public float vRange;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xpos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xpos, 0, yPos);
        Debug.Log("horizontalValueDisplayText.Text: " + h.ToString("F2"));
        Debug.Log("VerticalValueDisplayText.Text: " + v.ToString("F2"));
    }
}
