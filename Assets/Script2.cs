using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script2 : MonoBehaviour
{
    public GameObject ObjectToDeath;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Death"))
        {
            ObjectToDeath.gameObject.SetActive(false);
        }
    }
}
