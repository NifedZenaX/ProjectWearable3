using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

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
        else if(instance != this)
        {
            Destroy(instance.gameObject);
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PickCharacter(ChracterSO character)
    {
        this.character = character;
        SceneManager.LoadScene(4);
    }
}
