using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Movement : MonoBehaviour
    {
        private const float speed = 1.0f;
        private Rigidbody2D _controller;
        private Vector2 moveDirection = Vector2.zero;

        void Awake()
        {
            _controller = GetComponent<Rigidbody2D>();
        }
        
        void FixedUpdate()
        {
            var horizMovement = Input.GetAxis("Horizontal");
            var vertMovement = Input.GetAxis("Vertical");

            moveDirection = new Vector2(horizMovement, vertMovement);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed * Time.deltaTime;

            _controller.MovePosition(_controller.position + (moveDirection * speed * Time.deltaTime));
        }
    }
}
