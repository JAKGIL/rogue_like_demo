using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        double x = 0.2;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            transform.localPosition = transform.localPosition + new Vector3(0, (float)x, 0);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.localPosition = transform.localPosition + new Vector3(0, -(float)x, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {   
            ChangeSprite(newSprite);
            transform.localPosition = transform.localPosition + new Vector3(-(float)x, 0, 0);
        }
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localPosition = transform.localPosition + new Vector3((float)x, 0, 0);
        }        
    }
}
