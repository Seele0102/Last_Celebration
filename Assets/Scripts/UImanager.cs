using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class UImanager : MonoBehaviour
{
    public GameObject pauseMenuUI;  
    public Animator pauseAnimator;
    public Animator resumeAnimator;
    public Animator restartAnimator;
    public Animator exitAnimator;
    public float upSpeed;
    public float faderSpeed;
    public float lifeTimer;
    public AudioClip gameMusic;
    
    private void Update()
    {
        if (PlayerManager.IsHead)
        {

        }
        else
        {

        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("��f");
            Pause();
        }
    }

    private void Start()
    {
        AudioManager.Instance.PlayMusic(gameMusic, 0.5f);
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0;
        pauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
        resumeAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
        restartAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
        exitAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
    }

    public void Remake()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void OnExitGame()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene("StartGame");
    }

}
