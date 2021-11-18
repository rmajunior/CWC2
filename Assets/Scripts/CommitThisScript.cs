using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CommitThisScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
           
    
    #region SCENES

    ///<summary> Menu (0) and Main (1) </summary>

    public void goToMain()
    {
        //SceneManager.LoadScene("Main");
        SceneManager.LoadScene(1);
    }

    public void goToMenu()
    {
        //SceneManager.LoadScene("Menu");
        SceneManager.LoadScene(0);
    }

    public void quitApplication()
    {
        Application.Quit();
    }

    #endregion

}
