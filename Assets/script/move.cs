using System.Diagnostics;
using UnityEngine;
using UnityEngine.UIElements;

public class move : MonoBehaviour
{
    private float speed = 7;
    private float Hinput;
    private float Vinput;
    public GameObject canvas;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (canvas.GetComponent<Canvas>().isActiveAndEnabled == false)
            movekeybord();
    }
    public void movekeybord()
    {
        if (transform.position.z < -9.25 || transform.position.z > 9.25)
            this.transform.Translate(Vector3.forward * -Hinput * Time.deltaTime);
        if (transform.position.y < -5 || transform.position.y > 5)
            this.transform.Translate(Vector3.down * -Vinput * Time.deltaTime);

        Hinput = Input.GetAxis("Horizontal") * speed;
        Vinput = Input.GetAxis("Vertical") * -speed;
        this.transform.Translate(Vector3.forward * Hinput * Time.deltaTime);
        this.transform.Translate(Vector3.down * Vinput * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        
    }
}
