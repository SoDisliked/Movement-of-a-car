using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewCarItem;
{
    public partial class Car1 : Car
    {
        private Car myCar;

        public Car1()
        {
          myCar = newCar;  

          InitializeEntity();
        }

        private void GetCarData(Car car)
        {
            try{
                myCar.Make = txtMake.Text;

                myCar.Year = int.parse(txtModel.Text);

                myCar.Speed = 0;
            }
            catch ([System.Serializable]
            public class  Exception : System.Exception
            {
                public  Exception() { }
                public  Exception(string message) : base(message) { }
                public  Exception(string message, System.Exception inner) : base(message, inner) { }
                protected  Exception(
                    System.Runtime.Serialization.SerializationInfo info,
                    System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
            })
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            GetCarData();
            myCar.AccSpeed(5);
            message.box.show(" Your car is a " + myCar.Year + myCar.Make + " and it is travelling " + myCar.Speed + kmh");
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            GetCarData();
            myCar.DecSpeed(5);
            MessageBox.Show(" Your car is a " + myCar.Year + myCar.Make + " and it is traveling " + myCar.Speed + " kmh. ");
        }

        


            


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewCarItem;
{
    class Car 
    {
        private int year;
        private string Make;
        private int Speed; 

        public Car()
        {
            this.year = x;
            this.make = y; 
            this.speed = 0;
        }
    }
    public int AccSpeed
{
    get 
    { 
        Speed = Speed + 5;  //shorter code: Speed += 5;
        return Speed;
    }
}
public int DecSpeed
{
    get{
        Speed = Speed - 5; //shorter code: Speed -=5;
        return Speed;
    }
}
}
set speed = kmh;
set time = h;
set distance = km;
{
    get (Speed = Time * Distance);
    {
        if speed > 5;
        public int AccSpeed;
        else
        {
            public int DecSpeed;
        }
    }
}
{
    get (Speed = Time * Distance);
    {
        if speed < 5;
        public int DecSpeed;
        else
        {
            public int AccSpeed;
        }
    }
}
