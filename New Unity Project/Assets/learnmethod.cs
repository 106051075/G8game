
using UnityEngine;

public class learnmethod : MonoBehaviour
{
    private void Drive(int speed)
    {
        print("開車，時速:" + speed);
        print("音效~");

    }
    private void Shoot(int count,float speed,string prop = "無",string direction = "前方")
    {
        print("弓箭數量:" + count);
        print("弓箭速度:" + speed);
        print("弓箭屬性:" + prop);
        print("弓箭方向:" + direction);
    }
    private void Start()
    {
        print("哈囉，沃德~");
        Drive(100);
        Shoot(1, 15f, "冰屬性");
        Shoot(2, 20f, direction: "全角度無死角掃射");
    }
}
