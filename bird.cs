using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class bird : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float jumpstrg=17;
    public logicscript work;
    public bool alive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        work = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            myrigidbody.linearVelocity = Vector2.up * jumpstrg;

        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        work.gameover();
        alive = false;
        
    }
}
