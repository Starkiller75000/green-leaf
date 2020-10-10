using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using TMPro;


public class CaolScript : MonoBehaviour
{
    private int indice;
    private int life = 3;
    private float timer = 0f;
    private bool pressed = false;
    public static StaticClass score;
    private string[] dictionary = {"left", "up", "right", "down"};
    private string[] solution = new string[3];

    // Start is called before the first frame update
    void Start()
    {
        StaticClass.already = true;
        for (indice = 0; indice < 3; indice++)
        {
            int rand = Random.Range(0, dictionary.Length);
            solution[indice] = dictionary[rand];
            StaticClass.solution[indice] = solution[indice];
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

            if (Input.GetKey("up") && timer > 0.5f)
            {
                if ( System.Array.IndexOf(solution, "up") != -1 ) {
                    dist(); 
                    }
                timer = 0f;
            }
            if (Input.GetKey("down") && timer > 0.5f)
            {
                if ( System.Array.IndexOf(solution, "down") != -1 )
                    dist(); 
                timer = 0f;
            }
            if (Input.GetKey("left") && timer > 0.5f)
            {
                if ( System.Array.IndexOf(solution, "left") != -1 )
                    dist(); 
                timer = 0f;
            }
            if (Input.GetKey("right") && timer > 0.5f)
            {
                if ( System.Array.IndexOf(solution, "right") != -1 )
                    dist(); 
                timer = 0f;
            } 
    }

    private void dist() {
        life -= 1;
        if (life < 1)
        {
            Destroy(this.gameObject);
        }
    }
}
