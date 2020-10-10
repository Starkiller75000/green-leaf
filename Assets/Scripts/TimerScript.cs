using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public float goal;
    private TextMeshProUGUI texte;

    // Start is called before the first frame update
    void Start()
    {
        texte = GetComponent<TMPro.TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (goal > 0f)
        {
            goal -= Time.deltaTime;
            texte.text = goal.ToString("F2");
            if ( goal < 5f ) {
                texte.fontSize = 35f + goal * 4f;
            }
            texte.color = new Color32(50, 50, 50, 255);
        } else
        {
            SceneManager.LoadScene("defeat");
        }
    }
}
