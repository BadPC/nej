using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mat : MonoBehaviour {

    public string itemname;
    public float Pricevalue;
    public float Weight;

    public float GetPricePerWeight (float itemWeight, float itemPrice)
    {
        float price = itemPrice / itemWeight;
        return price;
    }

		
	
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(itemname + "costs" + GetPricePerWeight(Weight, Pricevalue) + "per weight"); 
        }
	}
}
