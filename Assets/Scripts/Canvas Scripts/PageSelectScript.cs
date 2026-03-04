using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PageSelectScript : MonoBehaviour
{
    //public to acces the dropdown menu and image to change its display
    public TMP_Dropdown PageDropdown; //this designates what row dropdown value is
    public Image ImagePage; //this is the image that holds the sprites

    //thie is code for changing the images 
    //public Image ImgaeIngridient (this is to designate what image is being changed) 

    //this holds the diffrent images fo display
    public Sprite Page1;
    public Sprite Page2;
    public Sprite Page3;
    public Sprite Page4;
    public Sprite Page5;



    // Update is called once per frame
    void Update()
    {
        if (PageDropdown.value == 0) //Page 1
        {
            ImagePage.sprite = Page1;
        }

        else if (PageDropdown.value == 1) //Page 2
        {
            ImagePage.sprite = Page2;
        }

        else if (PageDropdown.value == 2) //Page 3
        {
            ImagePage.sprite = Page3;
        }

        else if (PageDropdown.value == 3) //Page 4
        {
            ImagePage.sprite = Page4;
        }

        else if (PageDropdown.value == 4) //Page 5
        {
            ImagePage.sprite = Page5;
        }
    }


}
