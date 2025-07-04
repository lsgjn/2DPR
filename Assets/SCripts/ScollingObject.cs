using UnityEngine;

public class ScollingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        if (!GameManger.instance.isGameover)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        
    }
}
