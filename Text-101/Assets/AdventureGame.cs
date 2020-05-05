using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Agregamos este namespace para poder usar Text.
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    //SerializeField permite tener esto disponible en nuestro inspector, así Unity solo sugiere objetos de tipo texto
    [SerializeField] Text textComponent;
    // Agregamos al inspector el state
    [SerializeField] State startingState;

    /*
        //Declaración y creación de un Array
        int[] oddNumbers = { 1, 3, 5, 7, 9 };
        string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
    */
    // State es el type y state es la variable. Es el estado en el que estamos actualmente
    //Esto nos permite acceder a nuestra State class!!! La estamos instanciando
    State state;

    // Start is called before the first frame update
    void Start()
    {
        //El estado inicial es startingState
        state = startingState;
        //Accedemos a la prop text del textcomponent
        textComponent.text = state.GetStateStory();
        /*
            Debug.Log(oddNumbers[3]);
            Debug.Log(daysOfTheWeek[3]);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
