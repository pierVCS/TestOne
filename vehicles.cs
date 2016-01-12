//Pedro Pascasio - Phone: 07508495970 

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vCar = new Car("Diesel","Fiat","600");
			Vehicle vMoto = new Motorbike("1500","Ducatti","1500");
			Vehicle vBoat = new Boat("10000","Vasque","3",3);
			
			ArrayList Vehicles = new ArrayList();
			Vehicles.add(vCar);
			Vehicles.add(vMoto);
			Vehicles.add(vBoat);
			
			list(Vehicles);
			
		}
		
		static void list(Vehicles pVehicles)
        {
            Console.Clear();
            Console.WriteLine("****** Vehicles **********\n");
			Console.WriteLine("Engine - Manufacturer - Model - Unique Feature \n");
            for (int i = 0; i < pVehicles.Count; i++)
            {
                Console.WriteLine(pVehicles[i].ToString());
            }
            Console.ReadLine();
        }
    }
    
//---------------------------------------------------------------------

namespace Vehicles
{

    public abstract class Vehicle
    {
		string Engine;
		string Manufacturer;
		string Model;
		
		public string Engine
        {
            get { return engine;}
            set { engine = value;}
        }
		
		public string Manufacturer
        {
            get { return manufacturer;}
            set { manufacturer = value;}
        }
		
		public string Model
        {
            get { return model;}
            set { model = value;}
        }
        
		public Vehicle():this("","","")
        {}
        public Vehicle(string pEngine, string pManufacturer, string pModel)
        {
            engine = pEngine;
            manufacturer = pManufacturer;
            model = pModel;
        }    
		
		public override string  ToString()
        {
            return engine + "\t" + manufacturer + "\t" + model + "\t"; 
        }
    }	
	
	//------------ Derived classes ------------
	public class Car : Vehicle
    {
 
        int wheel;

        public int Wheel
        {
            get { return wheel; }
            set { wheel = value; }
        }
		
		public Car()
            : base()
        {
            wheel = 4;
        }
        public Car(string pEngine, string pManufacturer, string pModel)
            : base(pEngine, pManufacturer, pModel)
        {
            wheel = 4;
        }
		
		public override string ToString()
        {
            return base.ToString() + wheel + " wheels";
        }
    }
     
	public class Motorbike : Vehicle
    {
		int wheel;

        public int Wheel
        {
            get { return wheel; }
            set { wheel = value; }
        }
		
		public Motorbike()
            : base()
        {
            wheel = 2;
        }
        public Motorbike(string pEngine, string pManufacturer, string pModel)
            : base(pEngine, pManufacturer, pModel)
        {
            wheel = 2;
        }
        
		public override string ToString()
        {
            return base.ToString() + wheel + " wheels";
        }
    }
	
	public class Boat : Vehicle
    {
		int propeller; //number of blades

        public int Propeller
        {
            get { return propeller; }
            set { propeller = value; }
        }
		
		public Boat()
            : base()
        {
            propeller = 3;
        }
        public Boat(string pEngine, string pManufacturer, string pModel, int pPropeller)
            : base(pEngine, pManufacturer, pModel)
        {
            propeller = pPropeller;
        }
		
		 public override string ToString()
        {
            return base.ToString() + propeller + " blades";
        }
        
    }
}	
