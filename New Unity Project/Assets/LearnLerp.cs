
using UnityEngine;

public class LearnLerp : MonoBehaviour
{
    public Transform cube, sphree;
    public float speed = 3;
    private void Start()
    {
        Vector3 pos = Vector3.Lerp(cube.position, sphree.position, 0.5f*Time.deltaTime);
        cube.position = pos;
    }
}
