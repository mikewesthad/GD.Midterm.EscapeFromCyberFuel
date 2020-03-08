using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text ScoreTextBox;
    bool triggered;
    
    
    int i;
    
    void Start()
    {
        i = 0;
        triggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        triggered = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Hoop") && !triggered)
        {
            triggered = true;
            Destroy(other.gameObject);
            Debug.Log("Hoop destroyed.");
            Debug.Log("You have entered the trigger.");
            i++;
            Debug.Log("Score added.");
            Destroy(other.gameObject);
            Debug.Log("Trigger destroyed.");
            ScoreTextBox.text = $"Score: {i}";
        }
    }
}
