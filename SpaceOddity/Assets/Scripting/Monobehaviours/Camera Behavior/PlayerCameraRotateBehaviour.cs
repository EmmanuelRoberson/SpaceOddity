using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Camera
{
    [RequireComponent(typeof(PlayerCameraFollowBehaviour))]
    public class PlayerCameraRotateBehaviour : MonoBehaviour
    {
        // PlayerCameraFollowBehaviour reference
        private PlayerCameraFollowBehaviour _playerCameraFollowBehaviour;

        // Transform for this gameobject
        private Transform _selfTransform;

        // Target value for y rotation to reach
        private Vector3 _yRotationTarget;

        // Acts as a check to prevent rotation spamming,
        // and spamming could lead to bugs.
        private bool rotationComplete;

        public float RotationSmoothTime;

        // Rotation velocity reference (used in Vector3.SmoothDamp)
        private Vector3 _rotationVelocity;

        // Start is called before the first frame update
        void Start()
        {
            // Get PlayerCameraFollowBehaviourReference
            _playerCameraFollowBehaviour = GetComponent<PlayerCameraFollowBehaviour>();

            // Get transform reference
            _selfTransform = transform;

            // Set the current target to the current rotation
            _yRotationTarget = transform.eulerAngles;

            rotationComplete = true;
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Rotate(float rotationAmount)
        {
            if (rotationComplete)
            {
                rotationComplete = false;
                _yRotationTarget += new Vector3(0, rotationAmount, 0);

                if (_yRotationTarget.y < 0)
                    _yRotationTarget.y = 360 - rotationAmount;
                if (_yRotationTarget.y >= 360)
                    _yRotationTarget.y = 0;


                StartCoroutine(RotateCoroutine(Time.deltaTime));
            }
        }

        private IEnumerator RotateCoroutine(float deltaTime)
        {
            // Velocity value that only lasts the duration of the coroutine
            Vector3 rotationVelocity = new Vector3();

            while (Math.Abs(_selfTransform.eulerAngles.y - _yRotationTarget.y) > 0.0009)
            { 
                // Default smooth time set to 0.4f;
                _selfTransform.eulerAngles = Vector3.SmoothDamp(_selfTransform.eulerAngles, _yRotationTarget , ref rotationVelocity, RotationSmoothTime);

                yield return 0;
            }

            //quaternion


            rotationComplete = true;
            yield return 0;
        }

    }
}

