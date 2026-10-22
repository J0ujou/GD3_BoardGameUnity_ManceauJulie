using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Case : MonoBehaviour
{
    [SerializeField] private UnityEvent LaunchEvent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
        {
            Debug.Log("now");
            LaunchEvent.Invoke();
        }
    }
}
