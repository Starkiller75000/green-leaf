using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void onClickReturnToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main");
    }
}
