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

        // Speed of camera rotation
        public float RotationSpeed;

        // Start is called before the first frame update
        void Start()
        {
            // Get PlayerCameraFollowBehaviourReference
            _playerCameraFollowBehaviour = GetComponent<PlayerCameraFollowBehaviour>();

            // Get transform reference
            _selfTransform = transform;
        }

        // Update is called once per frame
        void Update()
        {
            float rotationDirection = Input.GetAxis("Horizontal");
            _selfTransform.Rotate(_selfTransform.up, Time.deltaTime * RotationSpeed * rotationDirection);
        }
    }
}

