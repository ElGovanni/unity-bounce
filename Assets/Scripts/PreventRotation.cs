using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventRotation : MonoBehaviour
{
    // Start is called before the first frame update
    private Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = rotation;
    }
}
