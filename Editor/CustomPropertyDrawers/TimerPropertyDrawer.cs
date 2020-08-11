using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace ACTools.TimeTracking
{
    [CustomPropertyDrawer(typeof(Timer))]
    public class TimerPropertyDrawer : PropertyDrawer
    {
        private const float additionSpace = 145f;
        private const float spacer = 2.5f;

        /// <summary> Draws the Unity Events within an IMGUIContainers. </summary>
        private void DrawUnityEvents(SerializedProperty property)
        {
            EditorGUILayout.PropertyField(property.FindPropertyRelative("OnFinished"));

            if (GUI.changed)
                property.serializedObject.ApplyModifiedProperties();
        }

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            VisualElement container = new VisualElement();

            PropertyField tickOnStartField = new PropertyField(property.FindPropertyRelative("tickOnStart"));
            PropertyField startValueField = new PropertyField(property.FindPropertyRelative("startValue"));
            PropertyField currentValueField = new PropertyField(property.FindPropertyRelative("currentValue"));
            IMGUIContainer eventsContainer = new IMGUIContainer(() => DrawUnityEvents(property));

            container.Add(tickOnStartField);
            container.Add(startValueField);
            container.Add(currentValueField);
            container.Add(eventsContainer);

            return container;
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            return base.GetPropertyHeight(property, label) + additionSpace;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            float defaultHeight = base.GetPropertyHeight(property, label);

            EditorGUI.BeginProperty(position, label, property);

            position = new Rect(position.x, position.y - 20f, position.width, defaultHeight);

            Rect tickOnStartRect = new Rect(position.x, position.y + defaultHeight + spacer, position.width, position.height);
            Rect startValueRect = new Rect(position.x, position.y + defaultHeight * 2f + spacer * 2f, position.width, position.height);
            Rect currentValueRect = new Rect(position.x, position.y + defaultHeight * 3f + spacer * 3f, position.width, position.height);
            Rect eventsRect = new Rect(position.x, position.y + defaultHeight * 4f + spacer * 3f, position.width, position.height);

            EditorGUI.PropertyField(tickOnStartRect, property.FindPropertyRelative("tickOnStart"), new GUIContent("Tick On Start"));
            EditorGUI.PropertyField(startValueRect, property.FindPropertyRelative("startValue"), new GUIContent("Start Value"));
            EditorGUI.PropertyField(currentValueRect, property.FindPropertyRelative("currentValue"), new GUIContent("Current Value"));
            EditorGUI.PropertyField(eventsRect, property.FindPropertyRelative("OnFinished"), new GUIContent("OnFinished"));

            EditorGUI.EndProperty();
        }
    }
}