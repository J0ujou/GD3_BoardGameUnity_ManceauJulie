using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Dice : MonoBehaviour
{
    private int faceNumber = 6;
    public int Actualface = 1;
    [SerializeField] private UnityEvent<int> LaunchDice;
    private bool keypressed = false;
    

    private int RandomDice()
    {
        Actualface = Random.Range(1, faceNumber+1);
        Debug.Log(Actualface);
        return Actualface;
    }
    
    void Update()
    {
        
        
            if (Keyboard.current.spaceKey.wasPressedThisFrame)
            {
                LaunchDice.Invoke(RandomDice());
                keypressed = true;
            }
        
    }

}
