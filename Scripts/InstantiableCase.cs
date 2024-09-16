using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WFCG_Case", menuName ="ScriptableObject/WFCGeneration/Case", order =1)]
public class InstantiableCase : ScriptableObject
{
    [SerializeField] private int _faceUp, _faceDown, _faceRight, _faceLeft, _faceFront, _faceBack;

    [SerializeField] private GameObject _casePrefab;

    public int FaceUp => _faceUp;
    public int FaceDown => _faceDown;
    public int FaceLeft => _faceLeft;
    public int FaceRight => _faceRight;
    public int FaceFront => _faceFront;
    public int FaceBack => _faceBack;

    public GameObject CasePrefab => _casePrefab;


}