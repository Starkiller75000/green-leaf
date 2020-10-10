using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageManager : MonoBehaviour
{
private Transform Parent;
public GameObject PrefabGameObject;

	void Start () {
        GameObject InstantiatedGameObject = Instantiate(PrefabGameObject, new Vector3(14, 5, 0), Quaternion.identity);     
	} 
}
