using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public Transform preFab;
    public int maxWoaw = 1000;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
       
       
        // this is where you check if the player has clikced on f

        if (Input.GetKeyDown(KeyCode.F))
        {
            print("Respect");
        }

    }
    public void printText()
    {
        print("pew pew pew");
    }
    public void playSpund()
    {
        GetComponent<AudioSource>().Play();
    }
    public void instantiateObject()
    {
        Instantiate(preFab, transform.position, Quaternion.identity);
    }
    public void instantiateObjects()
    {
        for (int i = 0; i < maxWoaw; i++)
        {
            Color col = Random.Range(0, 2) == 1 ? Color.black : Color.white;
            
            Instantiate(preFab, transform.position, Quaternion.identity);
           

        }
    }
            
 }

