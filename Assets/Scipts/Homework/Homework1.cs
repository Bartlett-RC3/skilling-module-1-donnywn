using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Homework1 : MonoBehaviour
{


    public int ningwang1int = 57;
    public float ningwang1float = 5.7f;
    public string ningwang1string = "my dog's name is rhino";

    public int[] ningwangintarray = { 1, 3, 5, 7, 9 };
    public List<string> ningwanglist = new List<string>() { "rhino", "hippo", "elephant" };
    public Dictionary<string, string> ningwangdictionary = new Dictionary<string, string>();




    void Start()
    {
        print("Lucky number" + " " + "is" + " " + ningwang1int);
        print("Lucky float number" + " " + "is" + " " + ningwang1float);
        print(ningwang1string);

        print(ningwangintarray[2] + ningwangintarray[4]);
        print(ningwangintarray.Length);
        print("favorite animal is" + " " + ningwanglist[0]);
        print("number of array is" + ningwangintarray.Length);

        ningwanglist.Add("Ape");
        ningwanglist.Add("lion");

        Debug.Log(ningwanglist.Count);


        ningwangdictionary.Add("gtr", "bmw");
        ningwangdictionary.Add("benz", "audi");

        print("nice car is" + " " + ningwangdictionary);


    }


}