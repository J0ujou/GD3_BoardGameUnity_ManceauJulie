using System.Collections;
using Unity.VisualScripting;
using UnityEngine.InputSystem;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerDatas data;

// actual position est set avec les données du scriptable object pour pas les perdre si on revient après un mini jeu
    public int ActualPosition
    {
        get => data.positionPlayer[data.ActualPlayer];
        set => data.positionPlayer[data.ActualPlayer] = value;
    }
    public int OldPosition = 0;
    public int NewPosition = 0;
    [SerializeField] Board board;
    [SerializeField] Dice dice;
    [SerializeField] float speed = 3f;
    private Vector3 offset = new Vector3(0,1f,0);
    private int NumberIndexOfCase => board.Cases.Count - 1;
    public bool ismoving = false;

    private void Start()
    {
        transform.position = (board.Cases[ActualPosition].transform.position) + offset;
    }
    
// input dans le player
    // private void Update()
    // {
    //     if (ismoving) return;
    //     if (Keyboard.current.spaceKey.wasPressedThisFrame)
    //     {
    //         dice.RandomDice();
    //     }
    // }
    
    public void Move(int number)
    {
        if (ismoving) return;

        int newPos = board.CalculateNewPosition(ActualPosition, number, out bool rebound);
        StartCoroutine(MovingSpacePSpace(ActualPosition, newPos, rebound, number <0));
    }

    private IEnumerator MovingSpacePSpace(int start, int end, bool rebound, bool backward)
    {
        ismoving = true;
        int current = start;
        bool goingBack = backward;
        // on continue tant qu'on n'est pas sur end
        // et, en cas de rebond, tant qu'on n'a pas encore touché la dernière case
        while (current != end || (rebound && !goingBack))
        {
            if (rebound && current == board.LastIndex) goingBack = true;

            current += goingBack ? -1 : 1;

            Vector3 goal = board.Cases[current].transform.position + offset;

            while (Vector3.Distance(goal, transform.position) > 0.01f)
            {
                transform.position = Vector3.MoveTowards(transform.position, goal, Time.deltaTime * speed);
                yield return null;
            }
            transform.position = goal;
        }

        OldPosition = ActualPosition;
        ActualPosition = end;
        ismoving = false;

        if (ActualPosition == board.LastIndex)
        {
            Debug.Log("win");
        }
    }
    
    /*public void Move(int number)
    {
        NewPosition += number;
        if(NewPosition> NumberIndexOfCase)
        {
            //objectif reculer mais la ca va directement sur la case voulue
            Debug.Log("stop");
            int TooMuch = NewPosition - NumberIndexOfCase;
            NewPosition = NumberIndexOfCase - TooMuch;
            PlayerMove(ActualPosition, NewPosition);
            OldPosition = ActualPosition;
            ActualPosition = NewPosition;
        }
        else if (NewPosition == NumberIndexOfCase || ActualPosition ==NumberIndexOfCase)
        {
            // si le joueur se retrouve pile sur la dernièra case
            OldPosition = ActualPosition;
            ActualPosition = NewPosition;
            Debug.Log("win");
        }
        else
        {
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
    }*/
    
    

}
