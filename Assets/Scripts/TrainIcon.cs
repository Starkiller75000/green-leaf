using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainIcon : MonoBehaviour
{
    private static StaticClass _data;
    private Image _trainIcon;
    private float currentScore = 10f;
    void Start()
    {
        _trainIcon = GetComponent<Image>();
    }

    private void FixedUpdate()
    {
            currentScore = StaticClass.score;
            _trainIcon.transform.Translate(Vector2.right * Time.fixedDeltaTime * (currentScore*0.01f));
            
    }
}
