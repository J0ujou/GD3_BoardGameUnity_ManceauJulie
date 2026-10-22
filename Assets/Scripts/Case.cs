using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Case : MonoBehaviour
{
    [SerializeField] public UnityEvent LaunchEvent;

    public void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            //Debug.Log("now");
            LaunchEvent.Invoke();
        }
    }
}
