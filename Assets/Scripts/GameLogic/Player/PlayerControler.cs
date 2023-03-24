using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
  
    private Rigidbody2D player;
    [SerializeField] private float _speedRight = 4F;
    [SerializeField] private float _speedLeft = 3F;
    public Animator anim;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }




    private void FixedUpdate()
    {
        Walking();
    }
    private void Walking()
    {
        //_moveInputX = Input.GetAxis("Horizontal");
        //if (Input.GetKey(KeyCode.D))
        //{
        //    player.velocity = new Vector2(_moveInputX * _speed, player.velocity.y);
        //} else if (Input.GetKey(KeyCode.A))
        //{
        //    player.velocity = new Vector2(-_moveInputX * _speed, player.velocity.y);
        //}
        //if(Input.GetKey(KeyCode.D) == true || Input.GetKey(KeyCode.A) == true)
        //{
        //    anim.SetFloat("HorizontalMove", 1);
        //}else
        //{
        //    anim.SetFloat("HorizontalMove", 0);
        //}


        if (Input.GetKey(KeyCode.D) && GetComponent<SpriteRenderer>().flipX == false)
        {

            transform.Translate(Vector2.right * _speedRight * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A) && GetComponent<SpriteRenderer>().flipX == false)
        {


            transform.Translate(Vector2.left * _speedLeft * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D) && GetComponent<SpriteRenderer>().flipX == true)
        {

            transform.Translate(Vector2.right * _speedLeft * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A) && GetComponent<SpriteRenderer>().flipX == true)
        {

            transform.Translate(Vector2.left * _speedRight * Time.deltaTime);
        }


    }

    private Camera _camera;
    private Vector3 pos;

    private void Start()
    {
        _camera = FindObjectOfType<Camera>();
    }



    void Update()
    {
        pos = _camera.WorldToScreenPoint(transform.position);
        FlipHero();

    }
    private void FlipHero()
    {
        if (Input.mousePosition.x < pos.x)
        {
            //transform.rotation = Quaternion.Euler(0, 180, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.mousePosition.x > pos.x)
        {
            //transform.rotation = Quaternion.Euler(0, 0, 0);

            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }



    }





}


