using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject MainCamara;
    public Vector2 a = new Vector3(600, 0,-2);
    public Vector2 b = new Vector3(0, 0,-2);
    public Vector2 c = new Vector3(-600, 0,-2);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void movimiento_camara_a()
    {
        MainCamara.transform.position = a;
    }
    public void movimiento_camara_b()
    {
        MainCamara.transform.position = b;
    }
    public void movimiento_camara_c()
    {
        MainCamara.transform.position = c;
    }
}
