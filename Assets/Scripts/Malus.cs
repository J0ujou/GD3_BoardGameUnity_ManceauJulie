using UnityEngine;

public class Malus : MonoBehaviour
{
        [SerializeField] int steps = -2;

        public void Apply(Player player)
        {
            player.Move(steps);
        }
}
