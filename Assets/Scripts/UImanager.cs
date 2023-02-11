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
    public Animator optionAnimator;
    public Text property;
    public GameObject Property;
    public float upSpeed;
    public float faderSpeed;
    public float lifeTimer;

    private void Start()
    {
        Destroy(Property,lifeTimer);
    }
    
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
            Debug.Log("°´f");
            Pause();
        }
        Property.transform.position+=new Vector3(0, upSpeed*Time.deltaTime, 0);
        Fader();
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
    public void Fader()
    {
        property.color = Color.Lerp(property.color, Color.white, faderSpeed * Time.deltaTime);
        if(property.color == Color.white)
        {
            property.color = Color.Lerp(property.color, Color.clear, faderSpeed * Time.deltaTime);
        }
    }
}
