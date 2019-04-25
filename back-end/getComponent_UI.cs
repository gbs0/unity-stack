using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditText()
{
  
  Text myText;
     
  void Start() {
    // Here the variable myText reference to the game Object MainText
    myText=GameObject.Find("MainText").GetComponent<Text>(); 
    
  }

  // Note that your function must be public if you want to atach the script to your text
  public void blablabla()  
  {
    myText.text = "Hello";    

    // or you can also do this
    string example="Hello2";
    myText.text=example // this will show you Hello2

   // there are also other function for example to change color

   myText.color=Color.red // your text color will  be red
  }   
} 