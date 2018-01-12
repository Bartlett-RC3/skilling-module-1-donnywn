using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework4 : MonoBehaviour 
{
    public GameObject popcorn;
    IEnumerator NingCouroutine;

    public Renderer poprend;
    IEnumerator NingColorCouroutine;

	// Use this for initialization
	void Start () 
    {
        NingCouroutine = popbomb();
        NingColorCouroutine = changePopcornColor();
	}
	
	// Update is called once per frame
	void Update () 

    {
		
	}
}
