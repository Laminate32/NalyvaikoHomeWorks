using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public GameObject Object;
    public Vector3 minscale = new Vector3(0.5f, 0.5f, 0.5f);
    public Vector3 maxscale = new Vector3(3f, 3f, 3f);

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Bigger"))
        {
            Object.transform.localScale += Vector3.one * Time.deltaTime;
        }
        if (Input.GetButtonDown("Less"))
        {
            Object.transform.localScale -= Vector3.one * Time.deltaTime;
        }

        Vector3 ScaleClamp = new Vector3(
            Mathf.Clamp(Object.transform.localScale.x, minscale.x, maxscale.x),
            Mathf.Clamp(Object.transform.localScale.y, minscale.y, maxscale.y),
            Mathf.Clamp(Object.transform.localScale.z, minscale.z, maxscale.z)
        );
        Object.transform.localScale = ScaleClamp;
    }
}
