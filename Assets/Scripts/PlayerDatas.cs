using UnityEngine;

[CreateAssetMenu(fileName = "PlayerDatas", menuName = "Scriptable Objects/PlayerDatas")]
public class PlayerDatas : ScriptableObject
{
    public int ActualPlayer;
    public int[] positionPlayer;

    // fonction qui permet de reset à qui est le tour et de leurs positions
    void ResetData(int nbPlayer)
    {
        ActualPlayer = 0;
        positionPlayer = new int[nbPlayer];
    }
}
