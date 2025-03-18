using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyComponent : MonoBehaviour
{
    public GameObject other;


    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(other);
        }
    }
}
