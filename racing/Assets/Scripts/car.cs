using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public GameObject leftLight;
    public GameObject rightLight;

    // Start is called before the first frame update
    void Start()
    {
        leftLight = GameObject.Find("leftLight");
        rightLight = GameObject.Find("rightLight");
        leftLight.SetActive(false);
        rightLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0f, 0f, 30f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0f, 0f, -20 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(0f, -30f * Time.deltaTime, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(0f, 30f * Time.deltaTime, 0f);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tunel")
        {
            leftLight.SetActive(true);
            rightLight.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "tunel")
        {
            leftLight.SetActive(false);
            rightLight.SetActive(false);
        }
    }

}
