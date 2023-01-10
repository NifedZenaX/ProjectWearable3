using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AppManager : MonoBehaviour
{
    public static AppManager instance;

    public ChracterSO character { get; private set; }
    public void Awake()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PickCharacter(ChracterSO character)
    {
        this.character = character;
        SceneManager.LoadScene(4);
    }
}
