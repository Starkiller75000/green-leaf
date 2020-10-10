using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waste : MonoBehaviour
{
    private float timer = 0.0f;
    private float threeshold = 4.0f;
    private bool emit = false;
    private bool already = false;
    private int life = 3;
    public GameObject Object;
    private GameObject tmp;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > threeshold && emit == false )
        {
            BarScript.health += 10f;
            emit = true;
        }
    }

    private void OnMouseDown()
    {
        life -= 1;
        if (life < 1)
        {
            Spawn();
            Destroy(this.gameObject);
        }
    }

    private void Spawn()
    {
        if (!already)
        {
          Instantiate(Object, new Vector3(-6, 5, 0), Quaternion.identity);
          already = true;  
        }
    }
}
