using UnityEngine;

public class Black : MonoBehaviour
{
    //fields
    public float manSpeed;
    private Animator animator;
    public bool walking;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        //TankFramerate();
        walking = false;
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, manSpeed * Time.deltaTime, 0);
            walking = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -manSpeed * Time.deltaTime, 0);
            walking = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(manSpeed * Time.deltaTime, 0, 0);
            walking = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-manSpeed * Time.deltaTime, 0, 0);
            walking = true;
        }
        animator.SetBool("walking", walking);
    }

    private void TankFramerate()
    {
        for (int i = 0; i < 10000; i++)
        {
            Debug.Log("hello");
        }
    }
}
