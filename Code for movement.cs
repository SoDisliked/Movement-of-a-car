using UnityEngine;
using System.Collections;

///////////////////////////////////////// ball /////////////////////////////////////
// xspeed: The X axis speed of the ball –                                         //
//           it will be calculated based on the mouse movement speed.             //
// yspeed: The Y axis speed of the ball –                                         //
//           it will be calculated based on the mouse movement speed.             //
// newyspeed: The updated Y acis speed of the ball                                //
//              after applying Newton and collision equations.                    //
// startingypos: The initial Y position of the ball –                             //
//               when stop dragging the ball.                                     //
// newxpos: The updated X position of the ball                                    //
// newypos: The updated Y position of the ball                                    //
// oldxpos: The previous X position of the ball                                   //
// oldypos: The previous Y position of the ball                                   //
// newx: The new X position of the mouse after dragging                           //
// oldx: The old X position of the mouse after dragging                           //
// newy: The new Y position of the mouse after dragging                           //
// oldy: The old Y position of the mouse after dragging                           //    
// acc: The acceleration = 10                                                     //
// t: The time                                                                    //
// xmouse: The X axis of the mouse pointer position                               //    
// ymouse: The Y axis of the mouse pointer position                               //
// dragging: Boolian variable to check whether the ball is being dragged or not.  //
// trace: Boolian variable to check if the trace option is on or off.             //
// collisiony: Boolian variable to check if the ball hits the ground or not.      //
////////////////////////////////////////////////////////////////////////////////////

// ball 1 variables
double xspeed,yspeed,newyspeed,startingypos;
double newxpos,newypos,oldxpos,oldypos;
double newx,oldx,newy,oldy;
double acc,t;
const int ground = 500;
int xmouse,ymouse;
bool dragging=true,trace,collisiony;

int choice = 1;
int numberofballs = 1;

Ballinstance b1 = new Ballinstance();

private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
{
    b1.play(ref xspeed,ref yspeed,
            ref newyspeed,ref startingypos,
            ref newxpos,ref newypos,ref oldxpos,ref oldypos,
            ref newx,ref oldx,ref newy,ref oldy,
            ref acc,ref t,
            ref xmouse,ref ymouse,
            ref dragging,ref trace,ref collisiony);
    ball.Left = (int)newxpos;
    ball.Top = (int)(ground - newypos);

    Collision();
}public class Ballinstance
{
    int xpos,ypos;
    const int ground = 0b1_1111_0100;

    public static int Ground => ground;

    public void play(
        ref double xspeed, ref double yspeed, ref double newyspeed, ref double startingypos, ref double newxpos, ref double newypos, ref double oldxpos, ref double oldypos, ref double newx, ref double oldx, ref double newy, ref double oldy, ref double acc, ref double t, ref int xmouse, ref int ymouse, ref bool dragging, ref bool trace, ref bool collisiony)
    {

        xpos = (int)newxpos;
        int newypos1 = (int)newypos;
        ypos = newypos1;
        int newxpos1 = (int)newxpos1;
        xpos = newxpos1;
    
        // this code will be visited 50 times per second while dragging
        if (dragging) 
        {
            // Grip the center of the ball when dragging
            xpos = xmouse;
            ypos = ymouse;

            // While dragging the starting y-axis position of the ball is ball.Top
            startingypos = ground - ypos;

            // Calculate the x and y speed based
            // on the mouse movement within 20 msec
            // speed = distance/time  ->  time = 20 millisecond
            // the speed is the change in the displacement
            // with respect to the time which
            // is already running (the code is within
            // the timer), so we don't have to divide 
            // by the time
            newx = xpos;
            newy = ground - ypos;
            xspeed = (newx-oldx)/1;
            yspeed = (newy-oldy)/1;
            oldx = newx;
            oldy = newy;

            // The time -while dragging- will not start yet
            t=0;

        } 
        else 
        {
            // This code will be visited 50 times per second while not dragging
            // The ball position is where it's last dragged
            oldxpos = xpos;
            // X-axis motion
            if(xpos < 580 && 0 < xpos)
            {
                newxpos = oldxpos + xspeed;
            } 
            else 
            {
                // Here the ball will hits the wall
                // Ball xspeed will decrease every time it hits the wall
                // Minus sign: to change the ball direction
                // when it collides with the walls
                // wall resestance, the ball will
                // lose some energy when hitting the wall
                xspeed *= -0.9;        
                newxpos = oldxpos + xspeed;
            }
    
            // Y-axis motion
            if(0 < newypos || collisiony)
            {   
                // Newton first motion equation
                newyspeed = yspeed - (acc*t);
                // Newton third motion equation
                newypos = startingypos + ((yspeed*t)- 0.5*acc*(t*t));
                // no collision happend
                collisiony = false;
            } 
            else 
            {
                // Here the ball will hits the ground
                // Initialize the ball variables again
                startingypos = -1;    
                // Here set startingypos=-1 not 0, because
                // if 0 newypos will be 0 every time the ball 
                // hits the ground so no bouncing
                // will happens to the ball, look to the 
                // eguation of newypos below when t = 0
                t = 0;
                // Ball yspeed will decrease every time it hits the ground
                // 0.75 is the elasticity coefficient
                // the initial speed(yspeed)
                // is 0.75 of the final speed(newyspeed)
                yspeed = newyspeed * -0.75;
                newypos = startingypos + ((yspeed*t)- 0.5*acc*(t*t));
                collisiony = true;
            }
            // Always
            // Ball xspeed will always decrease, even if it didn't hit the wall
            xspeed *= 0.99;    // air resistance

            #region explination of xspeed condition
            // This to stop the ball when it heading
            // to the left, you can notice that removeing
            // this condition will make the ball never
            // stop while its heading to the left until it will
            // hit the left wall, to know why,
            // run the simulation under the debuging mode and watch
            // the value of newxpos
            // newxpos = oldxpos + xspeed
            // when 0 < xspeed < 1 (the ball heading right),
            // ball.left = (int)newxpos, the casting 
            // forces the ball left position value
            // to be the same as its previous value
            // because oldxpos and newxpos are equals,
            // and hence the ball will stop.
            // but when -1 < xspeed < 0 (the ball heading left),
            // ball.left = (int)newxpos, the casting
            // here will not work correctly, because
            // the value of oldxpos(which is integer value) 
            // will always be decremented by the xspeed,
            // this will force the newxpos also to be 
            // always decremented by xspeed and
            // hence ball.left will always decremented 
            // by 1 (int) casting, and hence the ball will never stop.
            #endregion

            if(xspeed > -0.5 && xspeed < 0)
                xspeed = 0;
            // Update the ball position
            xpos = (int)newxpos;
            ypos = (int)(ground - newypos);
            // Increase the time
            t += 0.3;
        }
    }
}