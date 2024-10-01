using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;

    private GroundPiece[] allGroundPieces;

    // Start is called before the first frame update
    void Start()
    {
        SetupNewLevels();
    }

    private void SetupNewLevels()
    {
        allGroundPieces = FindObjectsOfType<GroundPiece>();
    }

}
