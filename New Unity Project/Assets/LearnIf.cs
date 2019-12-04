using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool opendoor;
    public int combo;
    public void Update()
    {
        if(opendoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }


        if (combo >= 100) 
        {
            print("攻擊*10");
        }
        else if (combo >= 50) 
        {
            print("攻擊*5");
        }
        else if (combo >= 10) 
        {
            print("攻擊*2");
        }
        else 
        {
            print("攻擊*1");
        }
    }

}