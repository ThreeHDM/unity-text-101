using System;
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
        ManageState();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
           Application.Quit();
        }
    }

    private void ManageState()
    {
        //Retornamos los nextstates y los guardamos en una variable. "var" puede ser usado como una forma rapida cuando una variable es declarada e inicializada. VS ya sabe que en este caso es de tipo State[] porque eso retorna el método
        var nextStates = state.GetNextStates();

 /*
  * Comentamos este código porque da un error si el usuario hace click en un elemento del array que no existe. Lo reemplazamos con un for loop
  * 
  * if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        } 
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = nextStates[2];
        }
*/

        for (int index = 0; index < nextStates.Length; index++)
        {
            //Sumamos el indice a Alpha1 y si es uno obtenemos boton Alpha2, etc.
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                //accedemos a la posición actual del array
                state = nextStates[index];
            }
            
        }
        textComponent.text = state.GetStateStory();
    }
}
