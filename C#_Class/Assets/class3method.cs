using UnityEngine;

public class class3method : MonoBehaviour
{
    //儲存帶有 person 類別的物件
    public person person1;
    public person person2;
     private void Start()
    {
        person1.talk();
        person2.talk();
        print("BMI"+person1.BMI());
        print("BMI" + person2.BMI());
        person1.walk(99,sound:"嘎嘎嘎");
        person2.walk(10,"左邊");



    }

    // Update is called once per frame

}
