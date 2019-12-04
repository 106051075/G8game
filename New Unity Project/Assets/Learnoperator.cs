using UnityEngine;

public class Learnoperator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 1;
    public int D = 2, E = 4;
    public int F = 5;
    public bool key;
    public int enemy;
    public float HP;
    private void Start()
    {
    }
    private void Update()
    {
        print("死亡:" + (HP <= 0));
        print("過關:" + (key || enemy >= 5));
    }
}
