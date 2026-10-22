using UnityEngine;
using UnityEngine.Events;

public class Bonus : MonoBehaviour
{
    [SerializeField] int steps = 2;

    public void Apply(Player player)
    {
        player.Move(steps);
    }
}
