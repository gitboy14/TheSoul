using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;


    public class PlayerControl : MonoBehaviour
    {
        public float speed = 6.0F;
        public float jumpSpeed = 8.0F;
        public float gravity = 20.0F;
        public bool canJump = true;
        public bool needGrounded;
        private Vector3 moveDirection = Vector3.zero;

        void Start()
        {

        }
        void Update()
        {//�ƶ�����
            CharacterController controller = GetComponent<CharacterController>();
        if (needGrounded)//�ڵ�����
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
                if (canJump && Input.GetButton("Jump"))
                    moveDirection.y = jumpSpeed;
            }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        //�߶ȼ��
        



        }

    }