using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Homework3 : MonoBehaviour 
{
    //Create a cube and move it across the screen

    int counter = 0;
    public GameObject NingCube;
    public Material viva;
    bool moveLeft = true;
    bool moveRight = false;
    float x = 0.1f;




	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(moveLeft == true)
        {
            if (counter >= -20)
            {
                gameObject.transform.Translate(Vector3.left);
                counter--;
            }
            else
            {
                moveLeft = false;
                moveRight = true;
                counter = -20;
            }
        }
        if (moveRight == true)
        {
            if (counter <= 20)
            {
                gameObject.transform.Translate(Vector3.right);
                counter++;
            }
            else
            {
                moveLeft = true;
                moveRight = false;
                counter = 20;
            }
        }
        if(Input.GetKey(KeyCode.Space))
        {
            gameObject.transform.Rotate(new Vector3(0,5,0));
        }

        if(Input.GetMouseButton(0))
        {
            viva.color = Color.red;
        }
        if (Input.GetMouseButton(1))
        {
            viva.color = Color.blue;
        }

	}
}
