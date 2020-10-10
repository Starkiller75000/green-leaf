using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarScript : MonoBehaviour
{

    Image healthBar;
    public Image timerBar;
    public static StaticClass score;
    private float timer;
    private float threeshold = 10f;
    float maxWaste = 100f;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Image>();
        health = 0f;        
    }

    // Update is called once per frame
    void Update()
    {
        if ( timer > threeshold ) {
            timer = 0f;
            int Height = (int) (GetComponent<RectTransform>().rect.height * healthBar.fillAmount);
            for (int i = 0; i < Height ; i++)
            {
                health = 0f;
                StaticClass.waste += 1; 
                i = i + 9;
            }
        } else {
            timer += Time.deltaTime;
            timerBar.fillAmount = timer*0.1f;
            healthBar.fillAmount = health / maxWaste;
        } 
    }
}
