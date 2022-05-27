using UnityEngine;
using System.Collections;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Please enter the radius of circle:");
    double circleRadius = Convert.ToDouble(Console.ReadLine());

    double circumferenceOfCircle = 2 * Math.PI * circleRadius;
    Console.WriteLine("Circumference of circle is: " + circumferenceOfCircle);

  }
}
Vector3 AngularvelocityToImpulse(Vector3 vel, Vector3 position)
{
   Vector3 R = position - body.worldCenterOfMass;
   Vector3 Q = MultiplyByInertiaTensor(vel);

   // condition (*)
   if (Math.Abs(Vector3.Dot(Q, R)) > 1e-5) 
      return new Vector3();

   // one solution
   // multiply by 0.5 because you need to apply this to both sides
   // fixes the factor-of-2 issue from before
   return 0.5 * Vector3.Cross(Q, R) / R.sqrMagnitude;
} 

Vector3 MultiplyByInertiaTensor(Vector3 v)
{
   return body.rotation * Mul(Quaternion.Inverse(body.rotation) * v, body.inertiaTensor);
}

Vector3 Mul(Vector3 v, Vector3 a)
{
   return new Vector3(v.x * a.x, v.y * a.y, v.z * a.z);
}
    private void SwitchSound()
    {
        if(onGas)
        {
            if(counterAccelerate == 20)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.clip = carAccelerateSound;
                audio.Play();
            }
 
            counterAccelerate++;
            if(counterAccelerate == 40)
            {
                counterAccelerate = 20;
            }
        }
        else
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = carEngineSound;
            audio.Play();
        }
    }
lblOmega.Text = "Ω";
set i as gear ratio i = Ωs/Ωe ;
set i value 10;20 ;
i = 20/10;
{ 
    if (rand.Next(10,20)) i < 20/10 ; 
    PutItem Item1 ;
}
{
    if (rand.Next(10,20)) i > 20/10 ;
    PutItem (new Item2) ;
}
Console.Writeline((float)yes/iterations) ; 

set gr as gear ratio rotations of Item2/ rotations of Item1 ; 
set i value 15;40 ;
i = 40/15 ; 
{
    if (rand.Next(15,40)) gr < 40/15 ;
    DropItem Item1 ; 
}
{
    if (rand.Next(15,40)) gr > 40/15 ; 
    PutItem (new Item2) ; 
}
Console.Writeline((float)yes/iterations) ;

set i value 35;70 ;
i = 70/35 ;
{
    if (rand.Next(35;70)) i < 70/35 ;
    DropItem Item2 ;
}
{
    if (rand.Next(35;70)) i > 70/35 ; 
    PutItem (new Item3) ;
}
Console.WriteLine((float)yes/iterations) ;