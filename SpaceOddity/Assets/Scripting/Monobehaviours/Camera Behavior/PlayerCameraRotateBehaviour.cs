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
        private Quaternion _rotationTarget;
        private Quaternion _previousRotation;

        // Acts as a check to prevent rotation spamming,
        // and spamming could lead to bugs.
        private bool rotationComplete;

        public float RotationSpeed;

        public float timeCount;

        // Rotation velocity reference (used in Vector3.SmoothDamp)
        private Vector3 _rotationVelocity;

        // Start is called before the first frame update
        void Start()
        {
            // Get PlayerCameraFollowBehaviourReference
            _playerCameraFollowBehaviour = GetComponent<PlayerCameraFollowBehaviour>();

            // Get transform reference
            _selfTransform = transform;

            rotationComplete = true;

            timeCount = 0;
        }

        // Update is called once per frame
        void Update()
        {

            _selfTransform.rotation = Quaternion.Slerp(_previousRotation, _rotationTarget, timeCount);

            timeCount += Time.deltaTime;

        }

        public void Rotate(float rotationAmount)
        {

            _previousRotation = transform.rotation;

        }
    }
}

