using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int[] myArray;
    public string[] secondArray;
void Start()
    {
        myArray = new int[] {0,0};
        secondArray = new[] { "0" };
    }
    void Update()
    {
        if (secondArray[0] == "+")       
        print(myArray[0] + myArray[1]);
        else if (secondArray[0] == "-")
        print(myArray[0] - myArray[1]);
        else if (secondArray[0] == "*")
        print(myArray[0] * myArray[1]);

    }
}
