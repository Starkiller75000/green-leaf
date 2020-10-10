using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutoManager : MonoBehaviour
{
    private float timer;
    public Text [] textes;
    private bool fading = false;
    private int i = 0;


    void Start () {
        for (int y = 0; y < textes.Length; y++)
        {
            textes[y].enabled = false;
        }
    }

    void Update () {
        timer += Time.deltaTime;
        if ( timer > 3f) {
            if ( i < textes.Length ) {
                if ( fading ) {
                    textes[i].CrossFadeAlpha(0.0f, 0.4f, false);
                    fading = false;
                    i++;
                } else {
                    textes[i].enabled = true;
                    textes[i].CrossFadeAlpha(1f, 0.2f, false);
                    fading = true;
                }
            }
            timer = 0f;
        }
    }
 
}
