using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralGrassgenerationScriptMurat : MonoBehaviour {
    public GameObject grassPrefab;
    public int amount;
    public Texture2D noiseTexture; // optional

    // private void Start() {
    //     GenerateGrass();
    // }

    private bool isGrassCommandReceived;
    private void Update() {
        if (!isGrassCommandReceived && Input.GetKeyDown(KeyCode.G)) {
            isGrassCommandReceived = true;
            GenerateGrass();
        }
    }

    public void GenerateGrass() {
        // generation code

        // 1. define positions (may be random, or noise based)

        // 2. instantiate object

        // 3. modify rotation randomly
        
    }

    private int NumOfObjectsToBeGenerated(Vector2 pos) {
        // loop noise texture

        // read pixel at position

        // lerp betveew 0 and max gen value according to pixel value...

        // return result

        return 0;
    }


}
