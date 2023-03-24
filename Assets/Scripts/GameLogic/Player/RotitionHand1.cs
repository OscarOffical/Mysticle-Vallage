using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotitionHand1 : MonoBehaviour
{
   
    public GameObject player;
    public float rotZ;
    public GameObject Layer;
    //public Transform _hand;
    //public GameObject light; 






    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ);

        //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        ////_hand.up = (mousePos - new Vector2(transform.position.x, transform.position.y));
        //transform.LookAt();

        if (rotZ > 90 || rotZ < -90)
        {
            //transform.rotation = Quaternion.Euler(0f, -180, -rotZ + offset);
            //spriteRenderer.flipY= true;

            //gameObject.transform.rotation = Quaternion.Euler(0, 0, +90 - rotZ);

            if (player.transform.eulerAngles.y == 0)
            {
                transform.localRotation = Quaternion.Euler(180, 0, -rotZ);
            }
            else if (player.transform.eulerAngles.y == 180f)
            {
                transform.localRotation = Quaternion.Euler(180, 180, rotZ);

            }


            Layer.GetComponent<SpriteRenderer>().sortingOrder = 4;

        }
        else
        {
            Layer.GetComponent<SpriteRenderer>().sortingOrder = 2;
        }
        //else
        //{
        //    //transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);
        //    //spriteRenderer.flipY = false;

        // gameObject.transform.rotation = Quaternion.Euler(0, 0, -90 + rotZ);
        //}




    }



}


