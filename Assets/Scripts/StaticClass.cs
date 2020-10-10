using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticClass : MonoBehaviour
{
    public static bool sucess;
    public static int waste = 0;
    public static int combo = 0;
    public static float score;
     public static string[] solution = new [] {
      "zero",
      "one",
      "two",
      };
    public static bool already = false;
    public static int speedmax;
    public static int nbofSpawn = 1;
    public static int DestroyCount = 0;

    void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
