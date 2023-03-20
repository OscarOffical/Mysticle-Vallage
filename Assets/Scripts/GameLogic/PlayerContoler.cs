using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoler : MonoBehaviour
{
    private float _moveInputX;
    private float _moveInputY;
    private Rigidbody2D player;
    [SerializeField] private float _speed = 6F;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        Walking();

    }
    private void Walking()
    {
        _moveInputX = Input.GetAxis("Horizontal");
        _moveInputY = Input.GetAxis("Vertical");
        player.velocity = new Vector2(_moveInputX * _speed, _moveInputY * _speed);
    }





}
