using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Main_Script : MonoBehaviour
{
    private float y_movement;
    private float x_movement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ///Check for movement
        transform.position += new Vector3(x_movement, y_movement, 0.000f);

        ///Movement input
        if (Input.GetKey(KeyCode.A))
        {
            x_movement = -0.100f;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            x_movement = 0.100f;
        }
        else
        {
            x_movement = 0.000f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            y_movement = 0.050f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            y_movement = -0.050f;
        }
        else
        {
            y_movement = 0.000f;
        }
    }

}
