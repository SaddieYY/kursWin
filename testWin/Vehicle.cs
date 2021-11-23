using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System;
namespace kursWin
{
    //перелічуваний тип types - для задання типів автомобіля
    public enum types
    {
        CAR,
        TRUCK
    };

    //клас cVehicle - користувацький клас, який містить дані про автомобіль
    public class cVehicle
    {
        [JsonIgnore]
        static int nextId = 1;
        [JsonIgnore]
        public int Id { get; private set; }
        [JsonIgnore]
        private string name;
        [JsonIgnore]
        private types type;
        [JsonIgnore]
        private double power;
        [JsonIgnore]
        private double consumption;
        [JsonIgnore]
        private double volume;

        [JsonPropertyName("Name")]
        public string Name { get => name; set {
                if (string.IsNullOrEmpty(value)) throw new Exception("Name is empty!"); name = value; } }
        [JsonPropertyName("Type")]
        public types Type { get => type; set { if(value < 0) throw new Exception("Parametr type has error value!"); type = value; } }
        [JsonPropertyName("Power")]
        public double Power { get => power; set { if (value < 0) throw new Exception("Parametr power has error value!");  power = value; } }
        [JsonPropertyName("Consumption")]
        public double Consumption { get => consumption; set { if (value < 0) throw new Exception("Parametr consumption has error value!"); consumption = value; } }
        [JsonPropertyName("Volume")]
        public double Volume { get => volume; set { if (value < 0) throw new Exception("Parametr volume has error value!");  volume = value; } }


        public cVehicle()
        {
            Name = "Default";
            Type = types.CAR;
            Power = 0;
            Consumption = 0;
            Volume = 0;
            Id = Interlocked.Increment(ref nextId);
        }
        public cVehicle(string name = "Default", types type = types.CAR,
                double power = 0, double consumption = 0, double volume = 0)
        {
            this.Name = name;
            this.Type = type;
            this.Power = power;
            this.Consumption = consumption;
            this.Volume = volume;
            Id = Interlocked.Increment(ref nextId);
        }
        public cVehicle(cVehicle other)
        {
            Name = other.Name;
            Type = other.Type;
            Power = other.Power;
            Consumption = other.Consumption;
            Volume = other.Volume;
            Id = Interlocked.Increment(ref nextId);
        }

        //статичний метод для запису даних у файл

        static public void WriteFile(FileStream fs, cVehicle veh)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true,
            };
            byte[] arr = Encoding.ASCII.GetBytes(JsonSerializer.Serialize(veh, options));
            if (!fs.CanWrite)
            {
                fs.Close();
                return;
            }
            fs.Write(arr, 0, arr.Length);
            fs.Close();
        }

        //статичний метод для зчитування інформації з файлу

        static public void ReadFile(FileStream fs, ref cVehicle veh)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true,
            };
            if (!fs.CanRead)
            {
                fs.Close();
                return;
            }
            byte[] arr = new byte[fs.Length];
            fs.Read(arr, 0, arr.Length);
            fs.Close();
            string textFromFile = System.Text.Encoding.Default.GetString(arr);
            cVehicle temp = JsonSerializer.Deserialize<cVehicle>(textFromFile, options);
            veh.Name = temp.Name;
            veh.Type = temp.Type;
            veh.Power = temp.Power;
            veh.Consumption = temp.Consumption;
            veh.Volume = temp.Volume;

        }

        //методи Compare - для порівняння даних про машини

        static public bool CompareToName(cVehicle it, cVehicle other)
        {
            int res = it.Name.CompareTo(other.Name);
            if (res < 0) return true;
            return false;
        }
        static public bool CompareToType(cVehicle it, cVehicle other)
        {
            if (it.Type > other.Type) return false;
            return true;
        }
        static public bool CompareToPower(cVehicle it, cVehicle other)
        {
            const double exp = 0.00001;
            if ((it.Power - other.Power) > exp || (it.Power > other.Power))
            {
                return true;
            }
            return false;
        }
        static public bool CompareToCon(cVehicle it, cVehicle other)
        {
            const double exp = 0.00001;
            if ((it.Consumption - other.Consumption) > exp || (it.Consumption > other.Consumption))
            {
                return true;
            }
            return false;
        }
        static public bool CompareToVolume(cVehicle it, cVehicle other)
        {
            const double exp = 0.00001;
            if ((it.Volume - other.Volume) > exp || (it.Volume > other.Volume))
            {
                return true;
            }
            return false;
        }
        static public bool CompareToLength(cVehicle it, cVehicle other)
        {
            if (it.volume / it.consumption > other.volume / other.consumption)
            {
                return true;
            }
            return false;
        }
    }
}

