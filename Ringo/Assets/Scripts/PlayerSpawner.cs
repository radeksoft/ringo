using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [Header("Player 1")]
    public GameObject playerOne;
    public float playerOneX;
    public float playerOneY;

    [Header("Player 2")]
    public GameObject playerTwo;
    public float playerTwoX;
    public float playerTwoY;
    
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerOne, new Vector3(playerOneX, playerOneY), Quaternion.identity);
        Instantiate(playerTwo, new Vector3(playerTwoX, playerTwoY), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
