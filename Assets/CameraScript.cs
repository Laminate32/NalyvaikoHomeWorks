using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraScript : MonoBehaviour
{
    public Camera MyCamera;
    public GameObject Cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cube.transform.position = new Vector3(15f, 15f, 15f);
        Cube.transform.localScale = new Vector3(4f, 4f, 4f);
        MyCamera.fieldOfView = 120f;
        MyCamera.backgroundColor = Color.blue;
        MyCamera.clearFlags = CameraClearFlags.SolidColor;
    }
}
