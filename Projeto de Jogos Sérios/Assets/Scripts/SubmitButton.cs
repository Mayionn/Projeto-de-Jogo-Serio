using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SubmitButton : MonoBehaviour {

    // Painel do Botão Submit
    public GameObject panel;

    // Game Objects para os botões
    public GameObject tryAgain;
    public GameObject continueGame;

    // Array que contém os gameobjects que quisermos
    public GameObject[] correct = { };
    public GameObject[] incorrect = { };

    // Array do texto que vai conter as respostas corretas e as incorretas
    public GameObject[] text = { };
    
    void Update ()
    {
        // Se o painel estiver ativo, os botões também irão estar. Isto resolve o problema dos botões aparecerem por baixo das tabs e ficarem inacessíveis
        if (panel.activeSelf)
        {
            tryAgain.SetActive(true);
            continueGame.SetActive(true);
        } 

        // Se o primeiro objeto do array estiver ativo, então o texto também vai estar ativo
        if (correct[0].activeInHierarchy)
         {
             text[0].SetActive(true);
         } else
         {
            text[0].SetActive(false);
         }

         if (correct[1].activeInHierarchy)
         {
             text[1].SetActive(true);
         } else
         {
            text[1].SetActive(false);
         }

         if (incorrect[0].activeInHierarchy)
         {
            text[2].SetActive(true);
         } else
         {
            text[2].SetActive(false);
         }

        // Se algum texto do array das respostas incorretas estiver visível, um botão a dizer "tentar outra vez" irá aparecer.
        // Caso não, um botão a dizer "continuar" vai aparecer, onde nos vai levar para o próximo nível
        if (text[2].activeInHierarchy)                                          // Texto "Tentar outra vez"
        {
            tryAgain.SetActive(true);
            continueGame.SetActive(false);
        } 
        if (text[0].activeInHierarchy && text[1].activeInHierarchy)             // Texto "Continuar"
        {
            continueGame.SetActive(true);
            tryAgain.SetActive(false);
        } else
        {
            tryAgain.SetActive(true);
            continueGame.SetActive(false);
        }
    }
}         

