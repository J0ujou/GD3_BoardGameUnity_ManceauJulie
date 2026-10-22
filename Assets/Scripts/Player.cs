using System.Collections;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int ActualPosition = 0;
    public int OldPosition = 0;
    public int NewPosition = 0;
    public int NumberIndexOfCase = 15;
    [SerializeField] Board board;
    private bool ismoving = false;

    private void Start()
    {
        transform.position= (board.Cases[ActualPosition].transform.position)+ new Vector3(0,1f,0);
    }
    
    public void Move(int number)
    {
        NewPosition += number;
        if(NewPosition> NumberIndexOfCase)
        {
            //objectif reculer
            Debug.Log("stop");
            int TooMuch = NewPosition - NumberIndexOfCase;
            NewPosition = NumberIndexOfCase - TooMuch;
            PlayerMove(ActualPosition, NewPosition);
            OldPosition = ActualPosition;
            ActualPosition = NewPosition;
        }
        else if (NewPosition == NumberIndexOfCase || ActualPosition ==NumberIndexOfCase)
        {
            OldPosition = ActualPosition;
            ActualPosition = NewPosition;
            Debug.Log("win");
        }
        else
        {
            Debug.Log("test");
            PlayerMove(ActualPosition, NewPosition);
            OldPosition = ActualPosition;
            ActualPosition = NewPosition;
        }
        

        void PlayerMove(int Actu, int New)
        {
            StartCoroutine(MovingSpacePSpace(Actu,New));
        }

        IEnumerator MovingSpacePSpace(int start, int end)
        {
            ismoving = true;
            // le pion avance case par case jusqu'à celle voulue
            for (int i = start + 1; i <= end; i++)
            {
                Vector3 goal = board.Cases[i].transform.position;
                //tant que le pion n'est pas à peu près sur la case voulu,il avance
                while (Vector3.Distance(goal, transform.position) > 0.01f)
                {
                    transform.position = Vector3.MoveTowards(transform.position, goal, Time.deltaTime * 3f);
                    yield return null;
                }
                transform.position = goal;
            }
            ismoving = false;
        }
    }
    
    

}
