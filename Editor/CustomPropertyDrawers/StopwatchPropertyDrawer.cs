using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace ACTools.TimeTracking
{
    [CustomPropertyDrawer(typeof(Stopwatch))]
    public class StopwatchPropertyDrawer : PropertyDrawer
    {
        private const float additionSpace = 25f;
        private const float spacer = 2.5f;

        public override VisualElement CreatePropertyGUI(SerializedProperty property)
        {
            VisualElement container = new VisualElement();

            PropertyField tickOnStartField = new PropertyField(property.FindPropertyRelative("tickOnStart"));
            PropertyField currentValueField = new PropertyField(property.FindPropertyRelative("currentValue"));

            container.Add(tickOnStartField);
            container.Add(currentValueField);

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
            Rect currentValueRect = new Rect(position.x, position.y + defaultHeight * 2f + spacer * 2, position.width, position.height);

            EditorGUI.PropertyField(tickOnStartRect, property.FindPropertyRelative("tickOnStart"), new GUIContent("Tick On Start"));
            EditorGUI.PropertyField(currentValueRect, property.FindPropertyRelative("currentValue"), new GUIContent("Current Value"));

            EditorGUI.EndProperty();
        }
    }
}