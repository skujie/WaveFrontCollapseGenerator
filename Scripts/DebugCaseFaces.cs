using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class DebugCaseFaces : MonoBehaviour
{
#if UNITY_EDITOR
    [SerializeField] private InstantiableCase _caseData;
    private void OnDrawGizmosSelected()
    {
        float cellSize = WFCG_Constants.WFCG_CELL_SIZE;

        Gizmos.color = new Color(0, .5f, 0f, .5f);
        Gizmos.DrawCube(transform.position, Vector3.one * cellSize);

        cellSize /= 1.75f;
        GUIStyle style = new();
        style.richText = true;
        style.fontSize = 24;
        style.normal.textColor = Color.green;

        Handles.Label(transform.position + Vector3.up * cellSize, _caseData.FaceUp.ToString(), style);
        Handles.Label(transform.position - Vector3.up * cellSize, _caseData.FaceDown.ToString(), style);
        Handles.Label(transform.position + Vector3.right * cellSize, _caseData.FaceRight.ToString(), style);
        Handles.Label(transform.position - Vector3.right * cellSize, _caseData.FaceLeft.ToString(), style);
        Handles.Label(transform.position + Vector3.forward * cellSize, _caseData.FaceFront.ToString(), style);
        Handles.Label(transform.position - Vector3.forward * cellSize, _caseData.FaceBack.ToString(), style);
    }
#endif
}
