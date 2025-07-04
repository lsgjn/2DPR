using UnityEngine;

public class FastMonig_x : MonoBehaviour
{
    public float speed = 4f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
{
    float range = 4f;

    // x = -4 ~ 4 사이를 빠르게 왕복
    float x = Mathf.PingPong(Time.time * speed, range * 2) - range;
    transform.position = new Vector3(x, transform.position.y, transform.position.z);
}

}
