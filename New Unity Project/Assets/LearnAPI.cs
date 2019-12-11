
using UnityEngine;

public class LearnAPI : MonoBehaviour

{
    public Transform Test1;
    public Transform Test2;

    private void Start()
    {
        print(Test1.position);

        Test1.localPosition = new Vector3(10, 10, 10);
        Test2.localPosition = Vector3.one * 5;
    }
    private void Update()
    {
        Test1.Rotate(0, 5, 0);
        Test2.Translate(0, 0, 1.5f);
    }
}