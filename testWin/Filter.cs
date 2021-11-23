using System;
using System.Collections.Generic;

namespace kursWin
{
    //клас cFilter - для фільтрування та сортування елементів списку
    class cFilter
    {
        public bool Filter { get; set; }
        public bool Sort { get; set; }
        private bool NameFil { get; set; }
        private bool TypeFil { get; set; }
        private bool PowerFil { get; set; }
        private bool ConFil { get; set; }
        private bool VolumeFil { get; set; }
        private bool NameSort { get; set; }
        private bool TypeSort { get; set; }
        private bool PowerSort { get; set; }
        private bool ConSort { get; set; }
        private bool VolumeSort { get; set; }
        private bool LengthSort { get; set; }
        public bool FlagSort { get; set; }


        private string name;
        private int type;
        private double power;
        private double consumption;
        private double volume;

        public string Name { get => name; set { if(NameFil) name = value; } }
        public int Type { get => type; set { if(TypeFil) type = value; } }
        public double Power { get => power; set { if(PowerFil) power = value; } }
        public double Consumption { get => consumption; set { if (ConFil) consumption = value; } }
        public double Volume { get => volume; set { if (VolumeFil) volume = value; } }

        public cFilter(bool filter = false, bool sort = false, bool name = false,
            bool type = false, bool power = false, bool con = false, bool volume = false)
        {
            Filter = filter;
            Sort = sort;
            NameFil = name;
            TypeFil = type;
            PowerFil = power;
            ConFil = con;
            VolumeFil = volume;
        }

        //метод для задання значень для фільтрування

        public void SetFilter(string name = "", int type = 0, double power = 0, double con = 0, double vol = 0)
        {
            Name = name;
            Type = type;
            Power = power;
            Consumption = con;
            Volume = vol;
            
        }

        //метод для задання параметрів сортування

        public void SetSort(bool name = false, bool type = false, bool power = false, bool con = false, bool vol = false, bool len = false)
        {
            NameSort = name;
            TypeSort = type;
            PowerSort = power;
            ConSort = con;
            VolumeSort = vol;
            LengthSort = len;
        }

        //метод злиття

        private void Merge(ref List<cVehicle> list, int left, int right, bool flag, Func<cVehicle, cVehicle, bool> compareToAny)
        {
            List<cVehicle> listTemp = new List<cVehicle>();
            int start = left, mid = (left + right) / 2, end = mid + 1;
            for (int i = left; i <= right; ++i)
            {
                if ((start <= mid) && ((end > right) || ((flag) ? (compareToAny(list[start], list[end])) : (!compareToAny(list[start], list[end])))))
                {
                    listTemp.Add(list[start]);
                    ++start;
                }
                else
                {
                    listTemp.Add(list[end]);
                    ++end;
                }
            }
            for (int i = left; i <= right; ++i)
            {
                list[i] = listTemp[i - left];
            }
        }

        //метод сортування злиттям

        public void MergeSort(ref List<cVehicle> list, int first, int last, bool flag, Func<cVehicle, cVehicle, bool> CompareToAny)
        {
            if (list.Count <= 1 ) return;
            if (first < last)
            {
                MergeSort(ref list, first, (first + last) / 2, flag, CompareToAny);
                MergeSort(ref list, ((first + last) / 2 + 1), last, flag, CompareToAny);
                Merge(ref list, first, last, flag, CompareToAny);
            }
        }

        //метод фільтрування елементів списку

        public void FilterList(ref List<cVehicle> list, ref List<cVehicle> filterlist)
        {
            filterlist.Clear();
            if (Filter)
            {
                foreach (var i in list)
                {
                    bool add = true;
                    if (NameFil && i.Name != Name) add = false;

                    if (TypeFil)
                    {
                        if (Type == 0 && i.Type != types.CAR) add = false;
                        if (Type == 1 && i.Type != types.TRUCK) add = false;
                    }
                    if (PowerFil && i.Power > Power) add = false;
                    if (ConFil && i.Consumption > Consumption) add = false;
                    if (VolumeFil && i.Volume > Volume) add = false;
                    if (add)
                    {
                        filterlist.Add(i);
                    }
                }
            }
            else
            {
                foreach (var i in list)
                {
                    filterlist.Add(i);
                }
            }
            if (Sort)
            {
                if (NameSort)
                {
                    MergeSort(ref filterlist, 0, filterlist.Count - 1, FlagSort, cVehicle.CompareToName);
                }
                if (TypeSort)
                {
                    MergeSort(ref filterlist, 0, filterlist.Count - 1, FlagSort, cVehicle.CompareToType);
                }
                if (PowerSort)
                {
                    MergeSort(ref filterlist, 0, filterlist.Count - 1, FlagSort, cVehicle.CompareToPower);
                }
                if (ConSort)
                {
                    MergeSort(ref filterlist, 0, filterlist.Count - 1, FlagSort, cVehicle.CompareToCon);
                }
                if (VolumeSort)
                {
                    MergeSort(ref filterlist, 0, filterlist.Count - 1, FlagSort, cVehicle.CompareToVolume);
                }
                if (LengthSort)
                {
                    MergeSort(ref filterlist, 0, filterlist.Count - 1, FlagSort, cVehicle.CompareToLength);
                }
            }
        }
    }
}
