using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene_change : MonoBehaviour
{private  const string Log = "joao";
    
private  const string Sen = "123";
[SerializeField]
private InputField InserLog= null;
[SerializeField]
private InputField InserSen= null;
[SerializeField]
private Text info=null;
        void Start()
    {
        InserLog.text=PlayerPrefs.GetString("LembreLog");
        InserSen.text=PlayerPrefs.GetString("LembreSen");
    }

    // Update is called once per frame
    public void FazerLog()
    {
        string login = InserLog.text;
        string senha = InserSen.text;
    }
}
