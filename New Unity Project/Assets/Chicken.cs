using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : MonoBehaviour
{
    // Start is called before the first frame update
    [Header ("G8雞基本資料"),Tooltip ("Call me G8"),Range (1,100)]
    public int speed = 10;
    public float turn = 20.5f;
    public string _Name = "G8雞";
    public bool mission;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
