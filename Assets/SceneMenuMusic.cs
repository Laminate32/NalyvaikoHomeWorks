using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneMenuMusic : MonoBehaviour
{
    public static SceneMenuMusic instance = null;

    void Awake()
    {
        // ���������� ������� ���������� ��'����
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
        // ϳ������ �� ���� ���� �����
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // ³������ �� ��䳿 ���� �����
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // ��������� ������ ��� ������� �� ����� �����
        if (scene.name == "SecondSceneName") // ������ "SecondSceneName" �� ����� ���� ����� �����
        {
            Destroy(gameObject);
        }
    }
}
