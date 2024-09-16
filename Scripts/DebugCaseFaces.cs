using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugCaseFaces : MonoBehaviour
{
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0, .5f, 0f, .5f);
        Gizmos.DrawCube(transform.position, Vector3.one * WFCG_Constants.WFCG_CELL_SIZE);
    }
}
