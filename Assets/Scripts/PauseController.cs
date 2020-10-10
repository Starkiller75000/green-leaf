using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject pauseMenuUI;
    public List<GameObject> uiElements;
    public Animator pauseAnimator;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            GamePause();
        }
    }

    private void GamePause()
    {
        if (gameIsPaused)
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            foreach (var uiElement in uiElements)
            {
                uiElement.SetActive(false);
            }
            pauseAnimator.enabled = !pauseAnimator.enabled;
            pauseAnimator.updateMode = AnimatorUpdateMode.UnscaledTime;
        }
        else
        {
            pauseMenuUI.SetActive(false);
            foreach (var uiElement in uiElements)
            {
                uiElement.SetActive(true);
            }
            Time.timeScale = 1f;
            pauseAnimator.enabled = !pauseAnimator.enabled;
        }
    }
}
