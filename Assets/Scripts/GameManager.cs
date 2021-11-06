using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool isGameStarted;
    [SerializeField] GameObject startingText;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }

        DontDestroyOnLoad(this);
    }
    void Start() 
    {
        
    }


    // public void StartGame()
    // {
    //     isGameStarted = true;
    //     startingText.SetActive(false);
    // }

    // public void FinishGame()
    // {
    //     Time.timeScale = 0f;
    // }

    // public void RetryGame()
    // {
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    // }

}