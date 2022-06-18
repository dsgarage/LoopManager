using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
    public enum Rarity{
        Common = 0,
        Rare = 1,
        SuperRare = 2
    }
    public class EnumPopup : MonoBehaviour
    {
        public Rarity rarity = Rarity.Common;
    }
#if UNITY_EDITOR
    [CustomEditor(typeof(EnumPopup))]
    public class EnumPopupEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EnumPopup myTarget = (EnumPopup)target;
            //DrawDefaultInspector();

            myTarget.rarity = (Rarity)EditorGUILayout.EnumPopup(myTarget.rarity);
        }
    }
#endif
