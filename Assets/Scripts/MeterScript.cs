using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeterScript : MonoBehaviour
{
    public static StaticClass score;
    private RectTransform selfTransform;

    // Start is called before the first frame update
    void Start()
    {
        selfTransform = GetComponent<RectTransform>();
        selfTransform.Rotate( new Vector3(0,0,0));
    }

    // Update is called once per frame
    void Update()
    {
        if ( StaticClass.combo != 0 ) {
            Quaternion currentRotation = selfTransform.rotation;
            Debug.Log(StaticClass.combo);
            Quaternion wantedRotation = Quaternion.Euler(0,0,45);
            selfTransform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation,-53f);
        } else {
            Quaternion currentRotation = selfTransform.rotation;
            Quaternion wantedRotation = Quaternion.Euler(0,0,0);
            selfTransform.rotation = Quaternion.RotateTowards(currentRotation, wantedRotation, Time.deltaTime * 15);
        }

        if ( selfTransform.eulerAngles.z > 45f && StaticClass.combo > 0  ) {
            StaticClass.combo -= 1;
        }
        StaticClass.score = (selfTransform.eulerAngles.z * 0.1f);
    }
}
