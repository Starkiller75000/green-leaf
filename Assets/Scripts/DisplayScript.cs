using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;

public class DisplayScript : MonoBehaviour
{
    public static StaticClass score;
    private bool isokay = true;
    private string str;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if ( StaticClass.already ) {
        for (var i = 0; i < 3; i++){
            str = str + " " + StaticClass.solution[i].ToString();
        }
        if ( isokay) {
            GetComponent<TMPro.TextMeshProUGUI>().text = str;
            isokay = false;
            }
        }
    }
}
