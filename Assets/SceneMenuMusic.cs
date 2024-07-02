using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenuMusic : MonoBehaviour
{
    public static SceneMenuMusic instance = null;

    void Awake()
    {
        // Збереження єдиного екземпляру об'єкта
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        // Підписка на подію зміни сцени
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // Відписка від події зміни сцени
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Вимкнення музики при переході на другу сцену
        if (scene.name == "SecondSceneName") // Замініть "SecondSceneName" на назву вашої другої сцени
        {
            Destroy(gameObject);
        }
    }
}
