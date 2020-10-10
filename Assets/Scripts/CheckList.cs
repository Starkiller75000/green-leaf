using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CheckList : MonoBehaviour
{
    private Transform Parent;
    public GameObject PrefabGameObject;
    public TextMeshProUGUI [] textes;
    private string[] dictionary = {"Objectif1", "Objectif2", "Objectif3"};

    // Start is called before the first frame update
    void Start()
    {
        GameObject InstantiatedGameObject = Instantiate(PrefabGameObject, transform.position, Quaternion.identity);
        Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Select()
    {
        for (int i = 0; i < textes.Length; i++)
        {
            textes[i].text = dictionary[i];
            textes[i].fontSize = 17;
        } 
    }
}
