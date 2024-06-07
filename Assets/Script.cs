using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Script : MonoBehaviour
{

    public void Scenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
    }
    void Update()
    {
        
    }
}
