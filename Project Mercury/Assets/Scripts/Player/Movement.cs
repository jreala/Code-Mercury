using UnityEngine;

namespace Assets.Scripts.Player
{
    public class Movement : MonoBehaviour
    {
        private const float speed = 1.0f;
        private CharacterController _controller;
        private Vector3 moveDirection = Vector3.zero;

        void Awake()
        {
            _controller = GetComponent<CharacterController>();
        }
        
        void FixedUpdate()
        {
            var horizMovement = Input.GetAxis("Horizontal");
            var vertMovement = Input.GetAxis("Vertical");

            moveDirection = new Vector3(horizMovement, 0.0f, vertMovement);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            _controller.Move(moveDirection);
        }
    }
}
