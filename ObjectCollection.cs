using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectCollection : MonoBehaviour
{

    public Text countText;
    public Text winText;

    [SerializeField] private int count;

    void OnCollisionEnter(Collision Col)
    {
        if (Col.gameObject.name == "Axe")
        {
            count = count + 1;
            SetCountText();
            Destroy(Col.gameObject);
        }
        if (Col.gameObject.name == "Bread")
        {
            count = count + 1;
            SetCountText();
            Destroy(Col.gameObject);
        }
        if (Col.gameObject.name == "Apple")
        {
            count = count + 1;
            SetCountText();
            Destroy(Col.gameObject);
        }
        if (Col.gameObject.name == "Bull Skull (XP Loss)")
        {
            count = count + 1;
            SetCountText();
            Destroy(Col.gameObject);
        }
    } 

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if(count >= 4)
        {
            winText.text = "win";
        }
    }

        // Start is called before the first frame update
            void Start()
    {
        winText.text = "You win!";
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
