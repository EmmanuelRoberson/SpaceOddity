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

        // Internal instead of private so custom editor class(PlayerCameraFollowBehaviourEditor) has access
        public bool FollowSmoothly;
        [HideInInspector] public float SmoothTime = 0.4f;
        private Vector3 _smoothVelocity;

        private Transform _selfTransform;

 

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
                Vector3.SmoothDamp(_selfTransform.position, targetPosition, ref _smoothVelocity, SmoothTime);
        }

        public Vector3 FocusObjectUp
        {
            get => _objectOfFocus.up;
        }

        public Vector3 FocusObjectForward
        {
            get => _objectOfFocus.forward;
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
            serializedObject.FindProperty(nameof(PlayerCameraFollowBehaviour.FollowSmoothly));
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