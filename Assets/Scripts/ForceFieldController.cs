using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceFieldController : MonoBehaviour
{
    private Vector3 startingPosition;
    public bool canShrink = false;
    private float timeRemaining;
    public float startTime;
    private Vector3 minScale = new Vector3(30, 30, 30);
    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(0, 25);
        float randomZ = Random.Range(0, 25);
        startingPosition.Set(randomX, 0, randomZ);
        transform.position = startingPosition;
        timeRemaining = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.sqrMagnitude > minScale.sqrMagnitude && canShrink)
        {
            timeRemaining -= Time.deltaTime;
            var newScale = (timeRemaining / startTime) * 80;
            transform.localScale = new Vector3(newScale, newScale, newScale);
        }
    }
    public void ResetField()
    {
        canShrink = false;
        timeRemaining = startTime;
        transform.localScale = new Vector3(80, 80, 80);
        float randomX = Random.Range(0, 25);
        float randomZ = Random.Range(0, 25);
        startingPosition.Set(randomX, 0, randomZ);
        transform.position = startingPosition;
    }
}
