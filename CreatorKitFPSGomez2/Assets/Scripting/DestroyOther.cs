using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(GetComponent<Renderer>());
        }
    }
}
