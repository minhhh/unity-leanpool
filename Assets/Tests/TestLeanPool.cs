using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean;

public class TestLeanPool : MonoBehaviour
{
    public GameObject prefab;

    // Use this for initialization
    void Start ()
    {
        LeanPool.Spawn (prefab);
    }
	
    // Update is called once per frame
    void Update ()
    {
		
    }
}
