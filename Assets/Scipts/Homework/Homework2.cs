using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NingGame;

public class Homework2 : MonoBehaviour {

    // Variables
    public int visvim = 7;
    public int price = 100;
    public bool supreme = true;
    int brandTime;
    string[] animals = { "rhino", "hippo", "elephant", "giraffe","ape"};

    List<Dog> DogTeam = new List<Dog>();

    void Start () 
    {

        Dog rere = new Dog("rere", "white", true, true, 4);
        Dog luca = new Dog("luca", "grey", true, true, 3);
        Dog lucky = new Dog("lucky", "black", false, false, 2);
        Dog yoyo = new Dog("yoyo", "brown", true, false, 5);

        DogTeam.Add(rere);
        DogTeam.Add(luca);
        DogTeam.Add(lucky);
        DogTeam.Add(yoyo);

        for (int i = 0; i < DogTeam.Count; i++)
        {
            Debug.Log(DogTeam[i].Getname()+" " + "is"+ " " + DogTeam[i].GetAge()+ " " + "years old");
            Debug.Log(DogTeam[i].Getname() +" " + "is a" +" " + DogTeam[i].GetColor() + " " + "doggy");
        }


        if(visvim==7&&supreme==true)
        {
            Debug.Log("I got visvim and supreme");
        }
        else
        {
            Debug.Log("visvim and supreme were sold out");
        }

        bool get = price <= 100;
        Debug.Log("I can get it if" + get);

        if (get)
            Debug.Log("visvim");

        string brand = get == false ? "visvim" : "supreme";
        Debug.Log("I like" + brand + "^_^");


        if(visvim == 6)
        {
            Debug.Log("the number of visvim is equal to 7.");
               
        }
        else
        {
            Debug.Log("the number of visvim is not equal to 7.");   
        }
        if(supreme)
        {
            Debug.Log("supreme is great");
        }
        else
        {
            Debug.Log("supreme is hard to get");
        }

        brandTime = (supreme == true) ? 1 : 0;
        Debug.Log("the value of brandTime is :" + brandTime);


        for (int i = 0; i < animals.Length; i = i + 1)
        {
            Debug.Log("animal at position" + i + "is" + animals[i]);
        }
        foreach (string animal in animals) 
        {
            Debug.Log(animal);
        }
    }
	

	void Update ()
        {
		
	}
}
