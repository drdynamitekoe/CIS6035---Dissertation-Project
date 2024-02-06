using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 90000f;

    CharacterController _characterController;
    public bool IsGrounded;

    private float resetCounter;

    void Awake() => _characterController = GetComponent<CharacterController>();

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 movement = transform.TransformDirection(direction) * _moveSpeed;
        IsGrounded = _characterController.SimpleMove(movement);
    }
}
