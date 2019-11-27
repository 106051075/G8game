using UnityEngine;

public class LearnAPIStatic : MonoBehaviour
{
    private void Start()
    {
        print(Random.value);
        print(Mathf.PI);
        print(Mathf.Abs(-1000000));
        print(Random.Range(50,150));

        Debug.Log("測試~");
        Debug.LogWarning("警告~");
        Debug.LogError("危險~");
    }
    private void Update()
    {
        print(Time.time);
        print(Input.GetKeyDown(KeyCode.Space));
    }
}
