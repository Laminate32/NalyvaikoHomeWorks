using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    public Light MyLight;
    public GameObject Sphere;
    void Start()
    {
        Sphere.transform.position = new Vector3(20f, 24.77f, 89.871f);
    }

    // Update is called once per frame
    void Update()
    {
        MyLight.intensity = 4f;
        MyLight.color = Color.black;
    }
}
