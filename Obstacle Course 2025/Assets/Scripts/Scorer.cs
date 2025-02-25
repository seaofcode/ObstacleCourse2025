using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision collision)
    {
        //hits = hits + 1;
        hits++;
        Debug.Log("You have hit something this many times: " + hits);
    }
}
