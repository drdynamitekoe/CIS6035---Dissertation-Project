using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControls : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f; //The speed the player is moving in
    [SerializeField] private float _turnSpeed = 10f;
    public float jumpForce = 500;
    private Rigidbody playerRb;
    public bool isOnGround = true;
    CharacterController _characterController;
    void Awake() => _characterController = GetComponent<CharacterController>();

    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(horizontal * _turnSpeed * Vector3.up, Space.World);

        float vertical = Input.GetAxis("Mouse Y");
        transform.Rotate(vertical * _turnSpeed * Vector3.up, Space.World);

        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Time.deltaTime * _turnSpeed * Vector3.down); //turns player left

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Time.deltaTime * _turnSpeed * Vector3.up); //turns player right

        if (Input.GetKey(KeyCode.D))
            transform.position += Time.deltaTime * _moveSpeed * transform.right; //moves player right

        if (Input.GetKey(KeyCode.A))
            transform.position += Time.deltaTime * _moveSpeed * -transform.right; //moves player left

        if (Input.GetKey(KeyCode.W))
            transform.position += Time.deltaTime * _moveSpeed * transform.forward; //moves player forward

        if (Input.GetKey(KeyCode.S))
            transform.position += Time.deltaTime * _moveSpeed * -transform.forward; //moves player back

        if (Input.GetKey(KeyCode.C))
        {
            transform.position += Time.deltaTime * _moveSpeed * -transform.up; //moves player Up
        }

        if (Input.GetKey(KeyCode.Z))
            transform.position += Time.deltaTime * _moveSpeed * transform.up; //moves player Down

    }
}

