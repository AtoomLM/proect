using UnityEngine;

public class des : MonoBehaviour
{
    public int timetodes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Des", timetodes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Des()
    {
        Destroy(gameObject);
    }
}
