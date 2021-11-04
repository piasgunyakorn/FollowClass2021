using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   public float speed = 1f;
    float newRotY = 0;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x;
        float newY = transform.position.y;
        float newZ = transform.position.z;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            newZ = transform.position.z + speed * Time.deltaTime;
            newRotY = -90;
            
        }
         if (Input.GetKey(KeyCode.DownArrow))
        {
            newZ = transform.position.z - speed * Time.deltaTime;
            newRotY = 90;
           
        }
         if (Input.GetKey(KeyCode.LeftArrow))
        {
            newX = transform.position.x - speed * Time.deltaTime;
            newRotY = 180;
            
        }
         if (Input.GetKey(KeyCode.RightArrow))
        {
            newX = transform.position.x + speed * Time.deltaTime;
            newRotY = 0;
            
        }
       
        transform.position = new Vector3(newX,newY,newZ);
        transform.rotation = Quaternion.Euler(0, newRotY, 0);
        transform.rotation = Quaternion.Lerp(
                                                transform.rotation,
                                                Quaternion.Euler(0, newRotY, 0),
                                                10 * Time.deltaTime
                                            );
    }
   
   private void OnCollisionEnter(Collision collision)
    {
       print(collision.gameObject.name);
        if (collision.gameObject.name == "Cube")
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
    }
}

