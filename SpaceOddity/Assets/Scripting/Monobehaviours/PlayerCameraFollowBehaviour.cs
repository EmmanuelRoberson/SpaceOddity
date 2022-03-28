using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Camera;

namespace Camera
{
    public class PlayerCameraFollowBehaviour : MonoBehaviour
    {
        [SerializeField] private Transform _objectOfFocus;

        // Determines how fast this object should follow the object of focus
        public float FollowSpeed;

        // Internal instead of private so custom editor class(PlayerCameraFollowBehaviourEditor) has access
        [SerializeField] private bool FollowSmoothly;
        [SerializeField] [HideInInspector] private float _smoothTime = 0.4f;
        internal Vector3 SmoothVelocity;

        private Transform _selfTransform;

        internal float SmoothTime
        {
            get => _smoothTime;
        }

        internal bool FollowSmoothlyGetter
        {
            get => FollowSmoothly;
        }

        // Start is called before the first frame update
        void Start()
        {
            _selfTransform = transform;
        }

        // Update is called once per frame
        void Update()
        {

        }

        void LateUpdate()
        {
            if (FollowSmoothly)
                SmoothFollow();
            else
                transform.position = _objectOfFocus.position;
        }

        void SmoothFollow()
        {
            // Get the object of focus position.
            Vector3 targetPosition = _objectOfFocus.position;

            // Calculate the next position for this object using Vector3.SmoothDamp, then assign it this transform.
            _selfTransform.position =
                Vector3.SmoothDamp(_selfTransform.position, targetPosition, ref SmoothVelocity, _smoothTime);
        }
    }
}

[CustomEditor(typeof(PlayerCameraFollowBehaviour))]
public class PlayerCameraFollowBehaviourEditor : Editor
{
    private SerializedProperty _smoothFollowSerializedProperty;
    private SerializedProperty _smoothTimeSerializedProperty;

    private void OnEnable()
    {
        // Assign each serialized property.
        _smoothFollowSerializedProperty =
            serializedObject.FindProperty(nameof(PlayerCameraFollowBehaviour.FollowSmoothlyGetter));
        _smoothTimeSerializedProperty =
            serializedObject.FindProperty(nameof(PlayerCameraFollowBehaviour.SmoothTime));

    }

    public override void OnInspectorGUI()
    {
        // Draws the other non-HideInInspector fields.
        DrawDefaultInspector();

        // Update the serialized object's representation (update its current values).
        serializedObject.Update();

        // If FollowSmoothly is true.
        if (_smoothFollowSerializedProperty.boolValue)
        {
            // Draw the other fields.
            EditorGUILayout.PropertyField(_smoothTimeSerializedProperty);
        }

        // Write back the changed values
        serializedObject.ApplyModifiedProperties();
    }
}