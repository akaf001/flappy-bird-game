using UnityEngine;

public class pipespawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 4;
    public float timer = 0;
    public float heigth = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer= timer+Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
      
    }
    void spawnpipe()
    {
        float low = transform.position.y - heigth;
        float high = transform.position.y + heigth;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(low,high),0), transform.rotation);

    }
}
