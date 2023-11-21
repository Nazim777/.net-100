using System;
using System.Drawing;
using Microsoft.VisualBasic;



class Program{


    static void MyMethod (string name="Mohammad Nazim Hossain"){
        Console.WriteLine("code to be extecuted!");
        Console.WriteLine($"Hello {name}!");
    }

    static int Average (int x, int y ,int z){
        return (x+y+z)/3;
    }
    static void Main(){
        // string UserName = "Mohammad";
        // int UserAge = 23;

        // Console.WriteLine("Hi, I'm "+ UserName +" and i'm " + UserAge + " years old age");
        // int age = 19;
        // if(age<18){
        //     Console.WriteLine("you can not drink!");
        // }else{
        //     Console.WriteLine("you can drink!");
        // }

    //     const string name = "Mohammad";
    //    Console.WriteLine(name);
    // Console.WriteLine("Enter your name");
    // string userName = Console.ReadLine();
    // Console.WriteLine("username is " + userName);

    // operators
    // arithmetic
    // int x = 2;
    // assignment
    // int y = 10;
    // y = y+4;
    // Console.WriteLine(y);
    // comparison
    // int x = 10;
    // int y = 6;
    // if(x>y){
    //     Console.WriteLine("hello world");
    // }

    // logical
    // if(x<20 && y>5){
    //     Console.WriteLine("Hello world!");
    // } else if(x<20 || y==5){
    //     Console.WriteLine("Hello world 2");
    // }

    // Math

    // int maxValue = Math.Max(10,20);
    // int minValue = Math.Min(10,20);
    // Console.WriteLine(maxValue);
    // Console.WriteLine(minValue);

    // string
    // string text = "Hello this is csharp";
    // Console.WriteLine(text.Length);
    // Console.WriteLine(text.ToUpper());
    // Console.WriteLine(text.ToLower());
    // string firstName = "Mohammad";
    // string lastName = " Nazim Hossain";
    // Console.WriteLine(firstName+lastName);
    // Console.WriteLine(string.Concat(firstName,lastName));
    // string name = $"my fullname is : { firstName} {lastName}";
    // Console.WriteLine(name);
    // string myString = "Hello";
    // Console.WriteLine(myString[0]);

    // while loop

    // int i = 0;
    // while(i<5){
    //     Console.WriteLine(i);
    //     i++;
    // }

    // for loop

    // for(int i=0; i<5; i++){
       
    //     Console.WriteLine(i);


    // }

    // break
    
    // for(int i=0; i<5; i++){
    //     if(i==3){
    //         break;
    //     }
    //     Console.WriteLine(i);


    // }

    // continue
    // for(int i=0; i<5; i++){
    //     if(i==3){
    //         continue;
    //     }
    //     Console.WriteLine(i);


    // }

    // foreach

    // string [] cars = {"Volvo", "BMW", "Ford", "Mazda"};
    // foreach(string i in cars){
    //     Console.WriteLine(i);
    // }

    // method
    //  MyMethod("Mohammad");
    //  MyMethod();
//    float value = Average(10,20,30);
//    Console.WriteLine(value);




// access class and object

//    Car car1 = new Car();
//    Console.WriteLine(car1.color);
//    Console.WriteLine(car1.brand);
//    string carColor = car1.color;
//    string carBrand = car1.brand;
//    Console.WriteLine(carColor);
//     Console.WriteLine(carBrand);
//     car1.color ="yellow";
//     car1.brand = "honda";
//     car1.year = 2002;
//     Console.WriteLine(car1.color);
//    Console.WriteLine(car1.brand);
//    Console.WriteLine(car1.year);

//    car1.hello();

// acess constructor
// Car car1 = new Car("blue","toyota",200);
// Car car2 = new Car("orange","honda",450);
// Console.WriteLine(car1.color);
// Console.WriteLine(car1.brand);
// Console.WriteLine(car1.maxSpeed);
// car1.Hello();
// car2.Hello();



        
    }
}



// class and object
// class Car{
//    public string color = "blue";
//    public string brand = "toyota";
//    public int year;
//     public void hello (){
//         Console.WriteLine($"the color of this car is {color} and brand of this car is {brand}");

//     }
// }



// constructor

// class Car{
//   public  string color;
//    public string brand;
//    public int maxSpeed;

//     public Car(string carColor, string carBrand, int carMaxSpeed){
//         this.color = carColor;
//         this.brand = carBrand;
//         this.maxSpeed = carMaxSpeed;
        
//     }

//     public void Hello (){
//         Console.WriteLine("the color of tis car is"+" "+color);
//     }



// }