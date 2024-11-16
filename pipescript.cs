using UnityEngine;

public class pipescript : MonoBehaviour
{
    public float speed = 5;
    private float deadzone = -32;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    transform.position = transform.position + (Vector3.left * speed)*Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
