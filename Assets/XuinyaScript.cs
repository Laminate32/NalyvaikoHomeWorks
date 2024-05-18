using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XuinyaScript : MonoBehaviour
{
    public GameObject firstcam;
    public GameObject secondcam;
    public GameObject thirdcam;
    void Start()
    {
        firstcam = GameObject.FindGameObjectWithTag("Gei1");
        secondcam = GameObject.FindGameObjectWithTag("Gei2");
        thirdcam = GameObject.FindGameObjectWithTag("Gei3");
    }

    // Update is called once per frame
    void Update()
    {
        firstcam.active = false;
        secondcam.active = false;
        thirdcam.active = true;
    }
}
