using UnityEngine;

public class Climbing_to_ladder : MonoBehaviour
{
    private float _vertical;
    private float _speed = 8f;
    private bool _isLadder;
    private bool _isClimbing;

    [SerializeField] private Rigidbody2D _rigidbody;
    void Update()
    {
        _vertical = Input.GetAxisRaw("Vertical");

        if (_isLadder && Mathf.Abs(_vertical) > 0f)
        {
            _isClimbing= true;
        }
    }
    private void FixedUpdate()
    {
        if (_isClimbing) 
        {
            _rigidbody.gravityScale = 0f;
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _vertical * _speed);
        }
        else
        {
            _rigidbody.gravityScale = 4f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            _isLadder = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ladder"))
        {
            _isLadder = false;
            _isClimbing = false;
        }
    }
}
