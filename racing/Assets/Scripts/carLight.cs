using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "tunel")
        {
            leftLight.SetActive(true);
            rightLight.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "tunel")
        {
            leftLight.SetActive(false); 
            rightLight.SetActive(false);
        }
    }
}
