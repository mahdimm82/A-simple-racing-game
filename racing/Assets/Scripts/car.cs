using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-5f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(5f * Time.deltaTime, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(0f, -10f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(0f, 10f * Time.deltaTime, 0f);
        }
    }
}
