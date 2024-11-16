using UnityEngine;

public class middlwscript : MonoBehaviour
{
    public logicscript work;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        work =GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            work.addscore();
        }
    }
}
