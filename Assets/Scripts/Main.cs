using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    Entity m_oMainLayout;
    Entity m_oCellLayout;

    Entity[][] m_oCells;

    void Start()
    {
        Setup.Initialize();

        //
        InitializeMainLayout();

        //
        InitializeCellLayout();

        //
        InitializeCells(m_oMainLayout);
    }

    void Update()
    {   
    }

    //Initialise le "m_oMainLayout" de facon à ce qu'il represente notre écran
    private void InitializeMainLayout()
    {
        m_oMainLayout = new Entity("MainLayout");

        //TODO
        //Positionner et Dimensionner "m_oMainLayout" en utilisant les variables calculées dans "Setup"
    }

    //Initialise le "m_oCellLayout"
    private void InitializeCellLayout()
    {
        m_oCellLayout = new Entity("CellLayout");

        //TODO
        //Positionner et Dimensionner "m_oCellLayout" en utilisant les variables calculées dans "Setup"
        //Celui-ci contiendra toutes les cases, et devra être dimensionné de manière à conserver leurs proportions
    }

    //Initialise toutes les cases en les ajoutants au layout de notre choix
    private void InitializeCells(Entity oLayout) 
    {
        m_oCells = new Entity[Setup.LINE][];
        for (int i = 0; i < m_oCells.Length; ++i)
        {
            m_oCells[i] = new Entity[Setup.COLUMN];
            for (int j = 0; j < m_oCells[i].Length; ++j)
            {
                Entity oCell = new Entity(Setup.CELL);
                m_oCells[i][j] = oCell;

                //TODO
            }
        }
    }
}