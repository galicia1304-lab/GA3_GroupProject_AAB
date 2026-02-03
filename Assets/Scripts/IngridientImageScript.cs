using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class IngridientImageScript : MonoBehaviour
{
    //public to acces the dropdown menu and image to change its display
    public TMP_Dropdown IngridientDropdown; //this designates what row dropdown value is
    public Image ImageIngridient;

    //thie is code for changing the images 
    //public Image ImgaeIngridient (this is to designate what image is being changed) 

    //this changes image sprite with ingridients
    //public sprite newImage 
    //{ ImageIngridient.sprite = newImage }
    //A drifrint image sprite would be needed to be set for each image
    

    // Update is called once per frame
    void Update()
    {
        if (IngridientDropdown.value == 0) //ingridient 1
        {
            ImageIngridient.color = Color.red;
        }

        else if (IngridientDropdown.value == 1) //ingridient 2
        {
            ImageIngridient.color = Color.blue;
        }

        else if (IngridientDropdown.value == 2) //ingridient 3
        {
            ImageIngridient.color = Color.green;
        }
    }
}
