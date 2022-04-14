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

        }

        public void RotateLeft()
        {
            _selfTransform.Rotate(_selfTransform.up, Time.deltaTime * RotationSpeed * -1);
        }

        public void RotateRight()
        {
            _selfTransform.Rotate(_selfTransform.up, Time.deltaTime * RotationSpeed * 1);
        }

        IEnumerator RotationCoroutine(float rotationAmount)
        {
            /*
            float startingRotation = _selfTransform.rotation.y;
            float rotationTarget = _selfTransform.rotation.y + rotationAmount;
            float rotationVelocity = 0;
            float amountRotated = 0;

            while (Math.Abs(amountRotated) <= Math.Abs(rotationAmount))
            {

                var currentRotationStep = Mathf.SmoothStep(startingRotation, rotationTarget, Time.deltaTime * RotationSpeed);

                //var currentRotationStep =
                 //   Mathf.SmoothDamp(_selfTransform.rotation.y, rotationTarget, ref rotationVelocity, 0.2f);

                _selfTransform.Rotate(_selfTransform.up, currentRotationStep);

                amountRotated += Math.Abs(currentRotationStep);

                yield return 0;
            }

            if (Math.Abs(360 - _selfTransform.rotation.y) < rotationAmount/2)
            {
                _selfTransform.SetPositionAndRotation(transform.position, new Quaternion(_selfTransform.rotation.x, 0, _selfTransform.rotation.z, _selfTransform.rotation.w));
            }
            */

            yield return 0;
        }
    }
}

