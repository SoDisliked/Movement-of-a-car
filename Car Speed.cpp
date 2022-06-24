#include <iostream>
#include<string>
using namespace std;

class Car
{
private:
	double YearModel;
	string Make;
	double Speed;

public:
	Car(double, string, double);
	double getSpeed();
	double getModel();
	void accelerate();
	void brake();
};

double Car::getSpeed()
{
	return Speed;
}

Car::Car(double YearModel, string Make, double Speed = 0)
{

}

void Car::accelerate()
{
	Speed = Speed + 15;
}

void Car::brake()
{
	Speed = Speed - 5;
}

int main()
{
	double YearModel;
	string Make;
	cout << "Enter the vehicles year and make ";
	cin >> YearModel >> Make;

	Car myCar(YearModel, Make);
	for (int a = 0; a < 15; a++)
	{
		myCar.accelerate();
		cout << "The current speed of the vehicle is: " << myCar.getSpeed() << endl;
	}

	for (int b = 0; b < 15; b++)
	{
		myCar.brake();
		cout << "The current speed of the vehicle is: " << myCar.getSpeed() << endl;
	}
	system("Pause");
	return 0;
}